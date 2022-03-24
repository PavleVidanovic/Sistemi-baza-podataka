using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Zgrada
    {
        public virtual int RedniBroj { get; set; }

        public virtual IList<Sprat> Spratovi { get; set; }
        public virtual IList<Lift> Liftovi { get; set; }
        public virtual IList<Ulaz> Ulazi { get; set; }
        public virtual IList<Ugovor> Ugovori { get; set; }

        public virtual Upravnik ZaduzenZaZgradu { get; set; }

        public Zgrada()
        {
            Spratovi = new List<Sprat>();
            Liftovi = new List<Lift>();
            Ulazi = new List<Ulaz>();
            Ugovori = new List<Ugovor>();
        }
    }
}
