using FluentNHibernate.Mapping;
namespace SalonLibrary.Entiteti;

public class KupovinaMap: ClassMap<Kupovina>
{
    public KupovinaMap()
    {
        Table("KUPOVINA");
        Id(x => x.Kupovina_Id, "Kupovina_Id").GeneratedBy.Sequence("kupovina_seq");
        Map(x => x.Konacna_cena, "Konacna_cena");
        Map(x => x.Dodatna_oprema, "Dodatna_oprema");

        References(x => x.Kupac).Column("Kupac_Id").Cascade.All();
        References(x => x.Promocija).Column("Prom_Id").Cascade.All();
        References(x => x.Placanje).Column("Placa_Id").Cascade.All();

        HasMany(x => x.NovaVozila)
            .KeyColumn("Kup_id")
            .Inverse()
            .Cascade.All();


        HasMany(x => x.PolovnaVozila)
            .KeyColumn("Kupo_id")
            .Inverse()
            .Cascade.All();

    }

}
