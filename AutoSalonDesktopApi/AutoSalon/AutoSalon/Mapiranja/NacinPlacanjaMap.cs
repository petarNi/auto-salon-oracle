using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSalon.Entiteti;
using FluentNHibernate.Conventions.Helpers;

namespace AutoSalon.Mapiranja
{
    class NacinPlacanjaMap: ClassMap<AutoSalon.Entiteti.NacinPlacanja>
    {
        public NacinPlacanjaMap()
        {
            Table("NACIN_PLACANJA");

            Id(x => x.Placanje_Id).Column("Placanje_Id").GeneratedBy.TriggerIdentity();

            Map(x => x.Tip, "Tip");
        }
    }
}
