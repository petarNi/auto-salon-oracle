using FluentNHibernate.Mapping;
namespace SalonLibrary.Entiteti;
public class NovaMap: ClassMap<Nova>
{
    public NovaMap()
    {
        Table("NOVA");
        Id(x => x.Br_sasije, "Br_sasije").GeneratedBy.Assigned();

        Map(x => x.Marka, "Marka");
        Map(x => x.Model, "Model");
        Map(x => x.God_proizvodnje, "God_proizvodnje");
        Map(x => x.Snaga_motora, "Snaga_motora");
        Map(x => x.Tip_goriva, "Tip_goriva");
        Map(x => x.Kilometraza , "Kilometraza");
        Map(x => x.Broj_vrata, "Broj_vrata");
        Map(x => x.Boja, "Boja");
        Map(x => x.Cena, "Cena");

        References(x => x.Kupovina).Column("Kup_id");
        References(x => x.Promocija).Column("Prom_id_novo");
        References(x => x.Salon).Column("Sal_id_nova");
        References(x => x.TestVoznja).Column("Voznja_id_nova");

    }
}
