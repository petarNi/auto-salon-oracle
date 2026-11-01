using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace SalonLibrary
{
    internal static class DataLayer
    {
        private static ISessionFactory? _factory = null;
        private static readonly object objLock = new();

        public static ISession? GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    _factory ??= CreateSessionFactory();
                }
            }

            return _factory?.OpenSession();
        }

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ShowSql()
                    .ConnectionString(c =>
                        c.Is(System.Environment.GetEnvironmentVariable("AUTOSALON_DB_CONNECTION")));

                return Fluently.Configure()
                    .Database(cfg)

                    // Bitno: koristi tip iz jedne od tvojih MAP klasa
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SalonMap>())

                    .BuildSessionFactory();
            }
            catch (Exception e)
            {
                Console.WriteLine("NHibernate greška: " + e.Message);

                // Ispis svih InnerException poruka
                var inner = e.InnerException;
                while (inner != null)
                {
                    Console.WriteLine("Inner: " + inner.Message);
                    inner = inner.InnerException;
                }

                return null;
            }
        }
    }
}
