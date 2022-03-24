using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Osoba
    {
        public virtual long MaticniBroj { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int BrojTelefona { get; set; }
        public virtual string Mesto { get; set; }
        public virtual string Ulica { get; set; }
    }
}
