using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Vlasnik : Osoba
    {

        public virtual IList<Stan> Stanovi { get; set; }

        public Vlasnik()
        {
            Stanovi = new List<Stan>();
        }

    }
}
