using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class Kupac
    {
        public virtual int Kupac_Id { get; protected set; }

        public virtual IList<Kupovina> Kupovine { get; set; }
        public virtual IList<TestVoznja> Voznje { get; set; }

        public Kupac()
        {
            Kupovine = new List<Kupovina>();
            Voznje = new List<TestVoznja>();
        }

    }
}
