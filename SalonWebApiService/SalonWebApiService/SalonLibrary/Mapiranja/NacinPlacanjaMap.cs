
using FluentNHibernate.Mapping; 
namespace SalonLibrary.Entiteti;
public class NacinPlacanjaMap: ClassMap<NacinPlacanja>
{
    public NacinPlacanjaMap()
    {
        Table("NACIN_PLACANJA");

        Id(x => x.Placanje_Id).Column("Placanje_Id").GeneratedBy.TriggerIdentity();

        Map(x => x.Tip, "Tip");
    }
}
