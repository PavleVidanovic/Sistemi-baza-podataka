using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDomaci.Entiteti
{
    public class Organizator
    {
        public virtual int ID_Organizatora { set; get; }

        public virtual String Ime { set; get; }
        public virtual String Prezime { set; get; }
        public virtual String Adresa { set; get; }
        public virtual String MBR { set; get; }
        public virtual Sudija Sudija_ID { set; get; }

        public virtual IList<Turnir> Turniri { get; set; }

        public Organizator()
        {
            Turniri = new List<Turnir>();
        }


    }
}
