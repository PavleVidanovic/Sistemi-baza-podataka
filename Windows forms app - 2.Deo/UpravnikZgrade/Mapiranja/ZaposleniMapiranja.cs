using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class ZaposleniMapiranja : SubclassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");
            KeyColumn("MATICNI_BROJ");
            Map(x => x.BrojLicneKarte).Column("BROJ_LICNE_KARTE");
            Map(x => x.MestoIzdavanjaLK).Column("MESTO_IZDAVANJA_LICNE_KARTE");
        }
    }
}
