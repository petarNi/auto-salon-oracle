using FluentNHibernate.Mapping;
namespace SalonLibrary.Entiteti;
public class SalonMap: ClassMap<Salon>
{
    public SalonMap()
    {
        Table("SALON");

        Id(x => x.Salon_Id, "Salon_Id").GeneratedBy.TriggerIdentity();

        Map(x => x.Tip_salona, "Tip_salona");
        Map(x => x.Naziv, "Naziv");
        Map(x => x.Adresa, "Adresa");
        Map(x => x.Telefon, "Telefon");
        Map(x => x.Radno_vreme, "Radno_vreme");
        Map(x => x.Broj_zaposlenih, "Broj_zaposlenih");
        Map(x => x.Proizvodjac, "Proizvodjac");

        HasMany(x => x.Zaposleni).KeyColumn("Salon_id_zap");

        HasMany(x => x.NovaVozila)
            .KeyColumn("Sal_id_nova")  
            .Inverse()
            .Cascade.All();

        
        HasMany(x => x.PolovnaVozila)
            .KeyColumn("Sal_id_polovna") 
            .Inverse()
            .Cascade.All();
    }
}
