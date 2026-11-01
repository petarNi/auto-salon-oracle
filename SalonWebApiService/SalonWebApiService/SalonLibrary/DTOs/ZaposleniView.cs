using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonLibrary.DTOs;
using SalonLibrary.Entiteti;

public class ZaposleniView : OsobaView
{
        public string? Pozicija { get; set; }
        public DateTime? Datum_zaposlenja { get; set; }
        public DateTime? Datum_funkcija { get; set; }
        public int? Broj_prodatih { get; set; }
        public int? Ocena_kupaca { get; set; }
        public int? SalonId { get; set; }
        public string? NazivSalona { get; set; }

        public ZaposleniView() 
        {
            
        }

        internal ZaposleniView(Zaposleni? z) : base(z)
    {
            if (z != null)
            {
                Pozicija = z.Pozicija;
                Datum_zaposlenja = z.Datum_zaposlenja;
                Datum_funkcija = z.Datum_funkcija;
                Broj_prodatih = z.Broj_prodatih;
                Ocena_kupaca = z.Ocena_kupaca;
                SalonId = z.Salon?.Salon_Id;
                NazivSalona = z.Salon?.Naziv;
            }
        }
}
