using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class SpratVisiMapiranja : SubclassMap<SpratVisi>
    {
        public SpratVisiMapiranja()
        {
            Table("VISI");
            KeyColumn("NIVO");

            HasMany(x => x.Stanovi).KeyColumn("NIVO3").LazyLoad().Cascade.All().Inverse();
        }
    }
}
