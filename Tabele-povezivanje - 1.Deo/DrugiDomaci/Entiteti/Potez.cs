using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;

namespace DrugiDomaci.Entiteti
{
    public class Potez
    {
        public virtual int ID_poteza { set; get; }
        public virtual int Redni_broj { set; get; }
        public virtual String Vreme { set; get; }
        public virtual String Ime { set; get; }
        public virtual Partija ID_partije { set; get; }

        

    }
}
