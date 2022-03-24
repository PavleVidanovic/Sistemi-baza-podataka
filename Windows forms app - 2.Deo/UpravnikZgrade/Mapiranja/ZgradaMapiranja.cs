using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class ZgradaMapiranja : ClassMap<Zgrada>
    {
        public ZgradaMapiranja()
        {
            Table("ZGRADA");

            Id(x => x.RedniBroj, "REDNI_BROJ").GeneratedBy.Assigned();

            References(x => x.ZaduzenZaZgradu).Column("MATICNI_BROJ2");

            HasMany(x => x.Spratovi).KeyColumn("REDNI_BROJ1").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Liftovi).KeyColumn("REDNI_BROJ5").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Ulazi).KeyColumn("REDNI_BROJ3").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Ugovori).KeyColumn("REDNI_BROJ6").LazyLoad().Cascade.All().Inverse();
        }
    }
}
