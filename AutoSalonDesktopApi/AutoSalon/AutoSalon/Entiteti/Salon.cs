


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class Salon
    {
        public virtual int? Salon_Id { get; protected set; }
        public virtual string Tip_salona { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Radno_vreme { get; set; }
        public virtual int Broj_zaposlenih { get; set; }
        public virtual string Proizvodjac { get; set; }

        public virtual IList<Zaposleni> Zaposleni { get; set; }
        public virtual IList<Nova> NovaVozila { get; set; }
        public virtual IList<Polovna> PolovnaVozila { get; set; }


        public Salon()
        {
            Zaposleni = new List<Zaposleni>();
            NovaVozila = new List<Nova>();
            PolovnaVozila = new List<Polovna>();

        }

    }
}
