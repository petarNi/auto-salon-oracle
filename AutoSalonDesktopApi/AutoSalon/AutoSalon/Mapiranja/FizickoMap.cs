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
    class FizickoMap: SubclassMap<Fizicko>
    {
        public FizickoMap()
        {
            Table("FIZICKO");
            KeyColumn("JMBG");

            Map(x => x.Adresa, "Adresa");
            References(x => x.Kupac).Column("Kupac_Id").Cascade.All();            
        }

    }
}
