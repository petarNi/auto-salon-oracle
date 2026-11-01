
namespace SalonLibrary.Entiteti;

public class Osoba
{
    public virtual string? JMBG { get; set; }
    public virtual string? Licno_ime { get; set; }
    public virtual string? Prezime { get; set;  }

    public virtual IList<string>? Emailovi {  get; set; }
    public virtual IList<string>? Telefoni {  get; set; }

    public Osoba()
    {
        Emailovi = new List<string>();
        Telefoni = new List<string>();
    }
}
