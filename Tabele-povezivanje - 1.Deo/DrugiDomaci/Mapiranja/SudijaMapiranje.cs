using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class SudijaMapiranje : ClassMap<Sudija>
    {
        public SudijaMapiranje()
        {
            Table("SUDIJA");
            Id(x => x.ID_Sudije).Column("ID_SUDIJE").GeneratedBy.SequenceIdentity("S16032.SEQ_SUDIJA");
            
            HasMany(x=>x.SudimPartije).KeyColumn("ID_SUDIJE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
