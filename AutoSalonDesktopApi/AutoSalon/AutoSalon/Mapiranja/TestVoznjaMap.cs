using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AutoSalon.Entiteti;

namespace AutoSalon.Mapiranja
{
    class TestVoznjaMap: ClassMap<TestVoznja>
    {
        public TestVoznjaMap()
        {
            Table("TEST_VOZNJA");
            Id(x => x.Voznja_Id, "Voznja_Id").GeneratedBy.TriggerIdentity();

            Map(x => x.Ocena, "Ocena");
            Map(x => x.Zakljucak, "Zakljucak");
            Map(x => x.Datum_termina, "Datum_termina");
            Map(x => x.Vreme_termina, "Vreme_termina");

            References(x => x.Zaposleni).Column("JMBG_zap").Cascade.All();
            References(x => x.Kupac).Column("Kupac_id").Cascade.All();

            HasMany(x => x.NovaVozila)
                .KeyColumn("Voznja_id_nova")
                .Inverse()
                .Cascade.All();


            HasMany(x => x.PolovnaVozila)
                .KeyColumn("Voznja_id_polovna")
                .Inverse()
                .Cascade.All();
        }
    }
}
