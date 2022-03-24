using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Ulaz
    {
        public virtual int RedniBrojUlaza { get; set; }
        public virtual string Kamera { get; set; }
        public virtual string VremeOtvoren { get; set; }

        public virtual Zgrada PripadaZgradi { get; set; }
    }
}
