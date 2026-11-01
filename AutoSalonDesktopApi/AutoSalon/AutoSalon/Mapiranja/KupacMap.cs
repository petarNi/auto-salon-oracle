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
    class KupacMap: ClassMap<Kupac>
    {
        public KupacMap()
        {
            Table("KUPAC");
            Id(x => x.Kupac_Id).Column("Kupac_Id").GeneratedBy.Sequence("KUPAC_SEQ");

            HasMany(x => x.Kupovine).KeyColumn("Kupac_Id").Inverse().Cascade.All();
            HasMany(x => x.Voznje).KeyColumn("Kupac_Id").Inverse().Cascade.All();
        }
    }
}
