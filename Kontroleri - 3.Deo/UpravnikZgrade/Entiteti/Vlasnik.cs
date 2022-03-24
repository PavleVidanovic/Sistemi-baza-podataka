using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Vlasnik : Osoba
    {

        public virtual IList<Stan> StanoviVlasnik { get; set; }

        public Vlasnik()
        {
            StanoviVlasnik = new List<Stan>();
        }

    }
}
