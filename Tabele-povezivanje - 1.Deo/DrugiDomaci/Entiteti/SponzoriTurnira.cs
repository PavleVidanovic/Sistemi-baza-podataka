using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;

namespace DrugiDomaci.Entiteti
{
    public class SponzoriTurnira
    {

        public virtual int Id_Sponzora { get; set; }
        public virtual String Sponzor { get; set; }
        public virtual Turnir ID_turnira { set; get; }

    }
}


