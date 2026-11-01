using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class Fizicko: Osoba
    {
        public virtual string Adresa  { get; set; }
        public virtual Kupac Kupac { get; set; }    

    }
}
