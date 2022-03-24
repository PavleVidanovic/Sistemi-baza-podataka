using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade.Entiteti
{
    public class Prevozni : Lift
    {
        public virtual int MaxOsoba { get; set; }
    }
}
