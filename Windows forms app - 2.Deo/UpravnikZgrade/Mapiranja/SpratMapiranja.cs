using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class SpratMapiranja : ClassMap<Sprat>
    {
        public SpratMapiranja()
        {
            Table("SPRAT");
            Id(x => x.Nivo, "NIVO").GeneratedBy.Assigned();

            References(x => x.PripadaZgradi).Column("REDNI_BROJ1").LazyLoad();
        }
    }
}
