
namespace SalonLibrary.Entiteti;

public class Kupovina
{
    public virtual int Kupovina_Id { get; set; }
    public virtual int? Konacna_cena { get; set; }
    public virtual string? Dodatna_oprema { get; set; }

    public virtual Kupac? Kupac { get; set; }
    public virtual Promocija? Promocija { get; set; }

    public virtual NacinPlacanja? Placanje { get; set; }
    public virtual IList<Nova> NovaVozila { get; set; }
    public virtual IList<Polovna> PolovnaVozila { get; set; }

    public Kupovina()
    {
        NovaVozila = new List<Nova>();
        PolovnaVozila = new List<Polovna>();
    }

}
