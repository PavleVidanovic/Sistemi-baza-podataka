using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Entiteti
{
    public class Zaposleni : Osoba
    {
        public virtual string MestoIzdavanjaLK { get; set; }
        public virtual int BrojLicneKarte { get; set; }
    }
   
}

