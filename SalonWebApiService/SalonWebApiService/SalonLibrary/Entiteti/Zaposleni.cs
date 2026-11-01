
namespace SalonLibrary.Entiteti;

public class Zaposleni: Osoba
{
    public  virtual string? Pozicija { get; set; }
    public  virtual DateTime? Datum_zaposlenja { get; set; }
    public  virtual DateTime? Datum_funkcija { get; set; }
    public virtual int? Broj_prodatih { get; set; }
    public virtual int? Ocena_kupaca { get; set; }
    public virtual Salon? Salon { get; set;  }
    public virtual IList<TestVoznja>? Voznje { get; set;  }
    public Zaposleni()
    {
        Voznje = new List<TestVoznja>();
    }
}
