using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class SpratPodzemni : Sprat
    {
        public virtual int BrojParkingMesta { get; set; }
        public virtual string Registracija { get; set; }
    }
}
