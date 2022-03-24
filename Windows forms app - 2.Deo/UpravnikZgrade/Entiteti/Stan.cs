using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Stan
    {
        public virtual int RedniBrojStana { get; set; }
        public virtual string ImenaStanara { get; set; }

        public virtual Vlasnik PripadaVlasniku { get; set; }
        public virtual SpratVisi JeDeo { get; set; }
    }
}
