using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Licenca
    {
        public virtual int BrojLicence { get; set; }
        public virtual DateTime DatumSticanja { get; set; }
        public virtual DateTime DatumObnove { get; set; }

        public virtual Upravnik JeStekao { get; set; }
    }
}
