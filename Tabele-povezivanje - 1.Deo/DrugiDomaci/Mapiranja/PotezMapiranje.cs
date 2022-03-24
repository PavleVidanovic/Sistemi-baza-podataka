using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class PotezMapiranje : ClassMap<Potez>
    {
        public PotezMapiranje()
        {
            Table("POTEZ");
            Id(x => x.ID_poteza).Column("ID_POTEZA").GeneratedBy.SequenceIdentity("S16032.SEQ_POTEZ");


            Map(x => x.Redni_broj).Column("REDNI_BROJ");
            Map(x => x.Vreme).Column("VREME");
            Map(x => x.Ime).Column("IME");

            References(x => x.ID_partije).Column("ID_PARTIJE").LazyLoad();
        }

    }
}
