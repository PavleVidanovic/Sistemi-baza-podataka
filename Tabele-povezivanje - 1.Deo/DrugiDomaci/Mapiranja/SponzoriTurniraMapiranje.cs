using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class SponzoriTurniraMapiranje : ClassMap<SponzoriTurnira>
    {
        public SponzoriTurniraMapiranje()
        {
            Table("SPONZORI_TURNIRA");
            Id(x => x.Id_Sponzora).Column("ID_SPONZORA").GeneratedBy.SequenceIdentity("S16032.SEQ_SPONZOR");

            Map(x => x.Sponzor).Column("SPONZOR");

            References(x => x.ID_turnira).Column("ID_TURNIRA").LazyLoad();
        }
    }
}
