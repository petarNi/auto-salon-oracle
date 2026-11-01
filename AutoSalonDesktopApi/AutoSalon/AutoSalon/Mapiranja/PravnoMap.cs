using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSalon.Entiteti;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;

namespace AutoSalon.Mapiranja
{
    class PravnoMap: ClassMap<Pravno>
    {
        public PravnoMap()
        {
            Table("PRAVNO");
            Id(x => x.PIB, "PIB").GeneratedBy.Assigned();
            Map(x => x.SedisteFirme, "Sediste_firme");
            Map(x => x.KontaktOsoba, "Kontakt_osoba");
            Map(x => x.NazivFirme, "Naziv_firme");

            References(x => x.Kupac).Column("Kupac_Id").Cascade.All();

            HasMany(x => x.Telefoni)
            .Table("TEL_PRAVNO")
            .KeyColumn("PIB_P")
            .Element("Tel_p_lica")
            .Cascade.All();

            HasMany(x => x.Emailovi)
            .Table("EMAIL_PRAVNO")
            .KeyColumn("PIB_PR")
            .Element("Email_p_lica")
            .Cascade.All();
        }
    }
}
