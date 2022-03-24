using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Upravnik : Zaposleni
    {
        public virtual string Pozicija { get; set; }
        public virtual string NazivInstitucije { get; set; }
        public virtual DateTime DatumDiplomiranja { get; set; }

        public virtual IList<Licenca> Licence { get; set; }
        public virtual IList<Zgrada> Zgrade { get; set; }

        public Upravnik()
        {
            Licence = new List<Licenca>();
            Zgrade = new List<Zgrada>();
        }

    }
}
