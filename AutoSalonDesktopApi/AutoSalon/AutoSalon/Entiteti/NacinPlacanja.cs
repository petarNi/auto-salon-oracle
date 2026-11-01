using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Entiteti
{
    public class NacinPlacanja
    {
        public virtual int Placanje_Id { get; protected set; }
        public virtual string Tip { get; set; }
    }
}
