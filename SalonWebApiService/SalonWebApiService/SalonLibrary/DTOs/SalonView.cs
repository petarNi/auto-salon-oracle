
namespace SalonLibrary.DTOs;
using SalonLibrary.Entiteti;
public class SalonView
{
    public virtual int Salon_Id { get; set; }
    public virtual string? Tip_salona { get; set; }
    public virtual string? Naziv { get; set; }
    public virtual string? Adresa { get; set; }
    public virtual string? Telefon { get; set; }
    public virtual string? Radno_vreme { get; set; }
    public virtual int? Broj_zaposlenih { get; set; }
    public virtual string? Proizvodjac { get; set; }

    public SalonView()
    {

    }

    internal SalonView(Salon? s)
    {
        if(s != null)
        {
            Salon_Id = s.Salon_Id;
            Tip_salona = s.Tip_salona;
            Naziv = s.Naziv;
            Adresa = s.Adresa;
            Telefon = s.Telefon;
            Radno_vreme = s.Radno_vreme;
            Broj_zaposlenih = s.Broj_zaposlenih;
            Proizvodjac = s.Proizvodjac;
        }
    }
}

