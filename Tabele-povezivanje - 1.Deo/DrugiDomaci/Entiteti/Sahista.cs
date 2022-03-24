using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDomaci.Entiteti
{
    public class Sahista
    {
        public virtual int Registracioni_broj { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Broj_pasosa { get; set; }
        public virtual String Adresa { get; set; }
        public virtual String Zemlja { get; set; }
        public virtual String Kategorija { get; set; }
        public virtual DateTime Datum_uclanjenja { get; set; }
        public virtual DateTime Datum_rodjenja { get; set; }

        public virtual IList<Partija> CrniBio { get; set; }
        public virtual IList<Partija> BeliBio { get; set; }
        public virtual IList<Turnir> UcestvovaoNaTurnirima { get; set; }

        
        public Sahista()
        {
            CrniBio = new List<Partija>();
            BeliBio = new List<Partija>();
            UcestvovaoNaTurnirima = new List<Turnir>();
        }


    }

    public class Majstor : Sahista
    {
        public virtual DateTime Datum_sticanja { get; set; }
        //public virtual int Sudija_ID { set; get; }

    }

    public class MK : Sahista
    {
        public virtual int Broj_partija_do_majstora { set; get; }
    }
    public class Obican : Sahista
    {

    }
}
