
using FluentNHibernate.Mapping;
namespace SalonLibrary.Entiteti;
public class KupacMap: ClassMap<Kupac>
{
    public KupacMap()
    {
        Table("KUPAC");
        Id(x => x.Kupac_Id).Column("Kupac_Id").GeneratedBy.Sequence("KUPAC_SEQ");

        HasMany(x => x.Kupovine).KeyColumn("Kupac_Id").Inverse().Cascade.All();
        HasMany(x => x.Voznje).KeyColumn("Kupac_Id").Inverse().Cascade.All();
    }
}
