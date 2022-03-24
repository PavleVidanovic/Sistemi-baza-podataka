using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class UpravnikMapiranja : SubclassMap<Upravnik>
    {
        public UpravnikMapiranja()
        {
            Table("UPRAVNIK");
            KeyColumn("MATICNI_BROJ");

            Map(x => x.NazivInstitucije).Column("NAZIV_INSTITUCIJE");
            Map(x => x.Pozicija).Column("POZICIJA");
            Map(x => x.DatumDiplomiranja).Column("DATUM_DIPLOMIRANJA");

            HasMany(x => x.Zgrade).KeyColumn("MATICNI_BROJ2").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Licence).KeyColumn("MATICNI_BROJ3").LazyLoad().Cascade.All().Inverse();

        }
    }
}
