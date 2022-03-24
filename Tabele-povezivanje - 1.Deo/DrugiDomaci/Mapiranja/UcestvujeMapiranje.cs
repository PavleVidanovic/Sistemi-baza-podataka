using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class UcestvujeMapiranje : ClassMap<Ucestvuje>
    {

        public UcestvujeMapiranje()
        {
            Table("UCESTVUJE");
            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("S16032.SEQ_UCESTVUJE");

            References(x => x.ID_Sahiste).Column("ID_SAHISTE").LazyLoad();
            References(x => x.ID_Turnira).Column("ID_TURNIRA").LazyLoad();
        }
    }
}
