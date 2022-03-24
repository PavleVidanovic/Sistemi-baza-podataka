using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;


namespace DrugiDomaci.Mapiranja
{
    public class PartijaMapiranje : ClassMap<Partija>
    {
        public PartijaMapiranje()
        {
            Table("PARTIJA");
            Id(x => x.ID_partije).Column("ID_PARTIJE").GeneratedBy.SequenceIdentity("S16032.SEQ_PARTIJA");

            Map(x => x.Datum).Column("DATUM");
            Map(x => x.Vreme).Column("VREME");
            Map(x => x.Trajanje).Column("TRAJANJE");
            Map(x => x.Rezultat).Column("REZULTAT");

            References(x => x.ID_sudije).Column("ID_SUDIJE").LazyLoad();
            References(x => x.ID_belog).Column("ID_BELOG").LazyLoad();
            References(x => x.ID_crnog).Column("ID_CRNOG").LazyLoad();
            References(x => x.ID_turnira).Column("ID_TURNIRA").LazyLoad();

            HasMany(x=>x.Potezi).KeyColumn("ID_PARTIJE").LazyLoad().Cascade.All().Inverse();



        }
    }
}
