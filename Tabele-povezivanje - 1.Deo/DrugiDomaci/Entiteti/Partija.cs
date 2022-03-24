using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;

namespace DrugiDomaci.Entiteti
{
    public class Partija
    {
        public virtual int ID_partije { get; set; }

        public virtual DateTime Datum { get; set; }
        public virtual String Vreme { get; set; }
        public virtual String Trajanje { get; set; }
        public virtual String Rezultat { get; set; }
        public virtual Sudija ID_sudije { get; set; }
        public virtual Sahista ID_belog { get; set; }
        public virtual Sahista ID_crnog { get; set; }
        public virtual Turnir ID_turnira { get; set; }

        public virtual IList<Potez> Potezi { get; set; }

        public Partija()
        {
            Potezi = new List<Potez>();
        }

       
    }
}
