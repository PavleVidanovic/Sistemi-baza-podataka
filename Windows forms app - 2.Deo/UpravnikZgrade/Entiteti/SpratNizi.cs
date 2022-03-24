using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class SpratNizi : Sprat
    {
        public virtual int RedniBrojLokala { get; set; }
        public virtual string ImeFirme { get; set; }
    }
}
