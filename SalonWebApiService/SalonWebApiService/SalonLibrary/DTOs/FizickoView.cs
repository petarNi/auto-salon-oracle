using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonLibrary.DTOs;
using SalonLibrary.Entiteti;


public class FizickoView : OsobaView
{
    public virtual string? Adresa { get; set; }
    public virtual Kupac? Kupac { get; set; }

    public FizickoView()
    {

    }

    internal FizickoView(Fizicko? f)
    {
        if (f != null)
        {
            Adresa = f.Adresa;
            Kupac = f.Kupac;
        }
    }
}
