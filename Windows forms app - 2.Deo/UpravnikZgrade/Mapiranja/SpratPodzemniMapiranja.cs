using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class SpratPodzemniMapiranja : SubclassMap<SpratPodzemni>
    {
        public SpratPodzemniMapiranja()
        {
            Table("PODZEMNI");
            KeyColumn("NIVO");

            Map(x => x.BrojParkingMesta).Column("BROJ_PARKING_MESTA");
            Map(x => x.Registracija).Column("REGISTRACIJA");
        }
    }
}
