using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Sprat
    {
        public virtual int Nivo { get; set; }

        public virtual Zgrada PripadaZgradi { get; set; }
    }
}
