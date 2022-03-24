using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;

namespace DrugiDomaci.Entiteti
{
    public class Sudija
    {
        public virtual int ID_Sudije { get; set; }

        public virtual IList<Partija> SudimPartije { get; set; }

        public Sudija()
        {
            SudimPartije = new List<Partija>();
        }

    }
}
