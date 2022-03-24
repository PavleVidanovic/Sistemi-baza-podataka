using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;

namespace DrugiDomaci.Entiteti
{
    public class Turnir
    {
        public virtual String Tip_turnira { get; protected set; }
        public virtual String Tip_poteza { get; set; }
        public virtual int ID_turnira { get; set; }
        public virtual String Naziv { get; set; }

        public virtual String Zemlja { get; set; }
        public virtual String Grad { get; set; }
        public virtual int Godina { get; set; }
        public virtual String Trajanje { get; set; }

        public virtual IList<Partija> Partije { get; set; }
        public virtual IList<Organizator> Organizatori { get; set; }
        public virtual IList<Sahista> Sahisti { get; set; }

        public Turnir()
        {
            Partije = new List<Partija>();
            Organizatori = new List<Organizator>();
            Sahisti = new List<Sahista>();
        }



    }
       public class TakmicarskiTurnir : Turnir
    {
        public virtual String Tip_takmicarskog { get; set; }
    }

    public class EgzibicioniTurnir : Turnir
    {
        public virtual String Tip_egzibicije { get; set; }
        public virtual String Namenjeno_za { get; set; }
        public virtual int Suma { get; set; }
    }

    public class NormalniTurnir : Turnir
    {
        
    }

    public class BrzopotezniTurnir : Turnir
    {
        public virtual int Max_vreme_trajanja {get; set;}
    }



}

