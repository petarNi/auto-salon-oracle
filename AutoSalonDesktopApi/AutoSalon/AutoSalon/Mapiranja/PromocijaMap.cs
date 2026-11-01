using AutoSalon.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Helpers;

namespace AutoSalon.Mapiranja
{
    class PromocijaMap: ClassMap<Promocija>
    {
        public PromocijaMap()
        {
            Table("PROMOCIJA");

            Id(x => x.Promocija_Id).Column("Promocija_Id").GeneratedBy.TriggerIdentity();

            Map(x => x.Uslovi, "Uslovi");
            Map(x => x.Naziv, "Naziv");
            Map(x => x.Period_trajanja, "Period_trajanja");
            Map(x => x.Popust, "Popust");

            HasMany(x => x.Kupovine).KeyColumn("Prom_Id").Inverse().Cascade.All();


            HasMany(x => x.NovaVozila)
                .KeyColumn("Prom_id_novo")
                .Inverse()
                .Cascade.All();


            HasMany(x => x.PolovnaVozila)
                .KeyColumn("Prom_id_polovno")
                .Inverse()
                .Cascade.All();
        }
    }
}
