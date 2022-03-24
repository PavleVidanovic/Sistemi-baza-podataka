using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDomaci.Entiteti
{
    public class Ucestvuje
    {

        public virtual int ID { get; set; }
        public virtual Sahista ID_Sahiste { get; set; }
        public virtual Turnir ID_Turnira { get; set; }

    }
}
