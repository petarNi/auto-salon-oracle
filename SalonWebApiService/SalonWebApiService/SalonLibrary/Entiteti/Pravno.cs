
namespace SalonLibrary.Entiteti;

public class Pravno
{
    public virtual required string PIB { get; set; }
    public virtual string? SedisteFirme { get; set; }
    public virtual string? KontaktOsoba { get; set; }
    public virtual string? NazivFirme { get; set; }

    public virtual Kupac? Kupac { get; set; }

    public virtual IList<string>? Emailovi { get; set; }
    public virtual IList<string>? Telefoni { get; set; }

    internal Pravno()
    {
        Emailovi = new List<string>();
        Telefoni = new List<string>();
    }
}
