

namespace SalonLibrary.Entiteti;

public class TestVoznja
{
    public virtual int Voznja_Id { get; set; }
    public virtual int Ocena { get; set;  }
    public virtual string? Zakljucak { get; set; }
    public virtual DateTime? Datum_termina { get; set; }
    public virtual string? Vreme_termina { get; set; }
    public virtual Zaposleni? Zaposleni { get; set; }
    public virtual Kupac? Kupac { get; set; }

    public virtual IList<Nova> NovaVozila { get; set; }
    public virtual IList<Polovna> PolovnaVozila { get; set; }

    public TestVoznja()
    {
        NovaVozila = new List<Nova>();
        PolovnaVozila = new List<Polovna>();
    }

}
