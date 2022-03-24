using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class VlasnikMapiranja : SubclassMap<Vlasnik>
    {
        public VlasnikMapiranja()
        {
            Table("VLASNIK");
            KeyColumn("MATICNI_BROJ");

            HasMany(x => x.StanoviVlasnik).KeyColumn("MATICNI_BROJ2").LazyLoad().Cascade.All().Inverse();
        }
    }
}
