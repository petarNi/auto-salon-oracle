using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonLibrary.DTOs;
using SalonLibrary.Entiteti;


public class OsobaView
{
    public string? JMBG { get; set; }
    public string? Licno_ime { get; set; }
    public string? Prezime { get; set; }
    public IList<string>? Emailovi { get; set; }
    public IList<string>? Telefoni { get; set; }

    public OsobaView()
    {

    }

    internal OsobaView(Osoba? o)
    {
        if (o != null)
        {
            JMBG = o.JMBG;
            Licno_ime = o.Licno_ime;
            Prezime = o.Prezime;
            Emailovi = o.Emailovi;
            Telefoni = o.Telefoni;
        }
    }
}
