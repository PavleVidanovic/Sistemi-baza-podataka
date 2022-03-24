using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class UlazMapiranja : ClassMap<Ulaz>
    {
        public UlazMapiranja()
        {
            Table("ULAZ");

            Id(x => x.RedniBrojUlaza, "REDNI_BROJ_ULAZA").GeneratedBy.Assigned();

            Map(x => x.Kamera).Column("KAMERA");
            Map(x => x.VremeOtvoren).Column("VREME_OTVOREN");

            References(x => x.PripadaZgradi).Column("REDNI_BROJ3").LazyLoad();
        }
    }
}
