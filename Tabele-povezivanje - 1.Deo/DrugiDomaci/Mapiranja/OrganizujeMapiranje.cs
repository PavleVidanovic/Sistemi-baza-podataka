using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class OrganizujeMapiranje: ClassMap<Organizuje>
    {
        public OrganizujeMapiranje() {
            Table("ORGANIZUJE");
            Id(x => x.Id).Column("ID").GeneratedBy.SequenceIdentity("S16032.SEQ_ORGANIZUJE");

            References(x => x.ID_Organizatora).Column("ID_ORGANIZATORA").LazyLoad();
            References(x => x.ID_Turnira).Column("ID_TURNIRA").LazyLoad();
        }

    }
}
