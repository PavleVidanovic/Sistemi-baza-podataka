using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class SpratVisi : Sprat
    {
        public virtual IList<Stan> Stanovi { get; set; }

        public SpratVisi()
        {
            Stanovi = new List<Stan>();
        }
    }
}
