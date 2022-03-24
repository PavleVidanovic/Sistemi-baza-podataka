using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class UgovorMapiranja : ClassMap<Ugovor>
    {
        public UgovorMapiranja()
        {
            Table("UGOVOR");
            Id(x => x.Sifra, "SIFRA").GeneratedBy.Assigned();

            Map(x => x.PeriodVazenja).Column("PERIOD_VAZENJA");
            Map(x => x.DatumPotpisivanja).Column("DATUM_POTPISIVANJA");

            References(x => x.PotpisujeZgrada).Column("REDNI_BROJ6").LazyLoad();
        }
    }
}
