using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class Polovna
    {
        public virtual string Br_sasije { get; set; }
        public virtual string Model { get; set; }
        public virtual string Marka { get; set; }
        public virtual int God_proizvodnje { get; set; }
        public virtual int Snaga_motora { get; set; }
        public virtual int Kilometraza { get; set; }
        public virtual int Broj_vrata { get; set; }
        public virtual string Boja { get; set; }

        public virtual string Tip_goriva { get; set; }
        public virtual int Cena { get; set; }
        public virtual DateTime Dat_poslednje_reg { get; set; }
        public virtual string Servisna_istorija { get; set; }
        public virtual int Br_preth_vlasnika { get; set; }

        public virtual Kupovina Kupovina { get; set; }
        public virtual Promocija Promocija { get; set; }
        public virtual TestVoznja TestVoznja { get; set; }
        public virtual Salon Salon { get; set; }

        public Polovna()
        {

        }
    }
}
