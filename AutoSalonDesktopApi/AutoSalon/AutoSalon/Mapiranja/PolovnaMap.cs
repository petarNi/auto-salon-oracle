using AutoSalon.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Mapiranja
{
    class PolovnaMap: ClassMap<Polovna>
    {
        public PolovnaMap() 
        {
            Table("POLOVNA");
            Id(x => x.Br_sasije, "Br_sasije").GeneratedBy.Assigned();

            Map(x => x.Marka, "Marka");
            Map(x => x.Model, "Model");
            Map(x => x.God_proizvodnje, "God_proizvodnje");
            Map(x => x.Snaga_motora, "Snaga_motora");
            Map(x => x.Tip_goriva, "Tip_goriva");
            Map(x => x.Kilometraza, "Kilometraza");
            Map(x => x.Broj_vrata, "Broj_vrata");
            Map(x => x.Boja, "Boja");
            Map(x => x.Dat_poslednje_reg, "Dat_poslednje_reg");
            Map(x => x.Servisna_istorija, "Servisna_istorija");
            Map(x => x.Br_preth_vlasnika, "Br_preth_vlasnika");
            Map(x => x.Cena, "Cena");
            References(x => x.Kupovina).Column("Kupo_id");
            References(x => x.Promocija).Column("Prom_id_polovno");
            References(x => x.Salon).Column("Sal_id_polovna");
            References(x => x.TestVoznja).Column("Voznja_id_polovna");
        }

    }
}
