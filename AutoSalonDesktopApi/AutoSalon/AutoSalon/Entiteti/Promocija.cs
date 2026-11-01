using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class Promocija
    {
        public virtual int Promocija_Id { get; protected set; }
        public virtual string Uslovi { get; set; }
        public virtual string Naziv { get; set;  }

        public virtual string Period_trajanja { get; set; }

        public virtual int Popust { get; set;  }

        public virtual IList<Kupovina> Kupovine { get; set; }
        public virtual IList<Nova> NovaVozila { get; set; }
        public virtual IList<Polovna> PolovnaVozila { get; set; }
        public Promocija()
        {
            Kupovine = new List<Kupovina>();
            NovaVozila = new List<Nova>();
            PolovnaVozila = new List<Polovna>();

        }
    }
}
