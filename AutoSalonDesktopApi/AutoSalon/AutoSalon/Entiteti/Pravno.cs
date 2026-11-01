using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class Pravno
    {
        public virtual string PIB { get; set; }
        public virtual string SedisteFirme { get; set; }
        public virtual string KontaktOsoba { get; set; }
        public virtual string NazivFirme { get; set; }

        public virtual Kupac Kupac { get; set; }

        public virtual IList<string> Emailovi { get; set; }
        public virtual IList<string> Telefoni { get; set; }

        public Pravno()
        {
            Emailovi = new List<string>();
            Telefoni = new List<string>();
        }
    }
}
