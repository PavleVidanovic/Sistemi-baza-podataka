using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Lift
    {
        public virtual string NazivProizvodjaca { get; set; }
        public virtual DateTime DatumPoslednjegKvara { get; set; }
        public virtual DateTime DatumPoslednjegServisiranja { get; set; }
        public virtual int SerijskiBroj { get; set; }
        public virtual int BrojPokvarenihDana { get; set; }

        public virtual Zgrada PripadaZgradi { get; set; }
    }

}
