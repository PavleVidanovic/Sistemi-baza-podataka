using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDomaci.Entiteti
{
    public class Organizuje
    {
        public virtual int Id { get; set; }
        public virtual Organizator ID_Organizatora { get; set; }
        public virtual Turnir ID_Turnira { get; set; }
    }
}
