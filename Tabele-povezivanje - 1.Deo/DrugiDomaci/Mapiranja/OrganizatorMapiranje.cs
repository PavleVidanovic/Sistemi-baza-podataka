using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class OrganizatorMapiranje : ClassMap<Organizator>
    {
        public OrganizatorMapiranje()
        {
            Table("ORGANIZATOR");
            Id(x => x.ID_Organizatora).Column("ID_ORGANIZATORA").GeneratedBy.SequenceIdentity("S16032.SEQ_ORGANIZATOR");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.MBR).Column("MBR");

            References(x => x.Sudija_ID).Column("SUDIJA_ID").LazyLoad();

            HasManyToMany(x => x.Turniri)
                .Table("ORGANIZUJE")
                .ParentKeyColumn("ID_ORGANIZATORA")
                .ChildKeyColumn("ID_TURNIRA")
                .Cascade.All();

            
    
        }

    }
}
