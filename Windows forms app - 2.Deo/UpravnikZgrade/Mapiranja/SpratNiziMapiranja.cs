using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class SpratNiziMapiranja : SubclassMap<SpratNizi>
    {
        public SpratNiziMapiranja()
        {
            Table("NIZI");
            KeyColumn("NIVO");

            Map(x => x.ImeFirme).Column("IME_FIRME");
            Map(x => x.RedniBrojLokala).Column("REDNI_BROJ_LOKALA");
        }
    }
}
