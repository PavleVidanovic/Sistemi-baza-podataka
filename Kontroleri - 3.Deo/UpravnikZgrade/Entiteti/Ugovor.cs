using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Ugovor
    {
        public virtual int Sifra { get; set; }
        public virtual DateTime DatumPotpisivanja { get; set; }
        public virtual int PeriodVazenja { get; set; }

        public virtual Zgrada PotpisujeZgrada { get; set; }
    }
}
