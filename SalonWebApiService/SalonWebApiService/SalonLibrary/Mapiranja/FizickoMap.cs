
using FluentNHibernate.Mapping;
namespace SalonLibrary.Entiteti;

public class FizickoMap: SubclassMap<Fizicko>
{
    public FizickoMap()
    {
        Table("FIZICKO");
        KeyColumn("JMBG");

        Map(x => x.Adresa, "Adresa");
        References(x => x.Kupac).Column("Kupac_Id").Cascade.All();            
    }

}
