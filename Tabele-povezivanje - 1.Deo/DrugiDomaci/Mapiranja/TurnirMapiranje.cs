using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;
using DrugiDomaci.Mapiranja;

namespace DrugiDomaci.Mapiranja
{
    public class TurnirMapiranje : ClassMap<Turnir>
    {

        public TurnirMapiranje()
        {
            Table("TURNIR");
            DiscriminateSubClassesOnColumn("TIP_TURNIRA");
            DiscriminateSubClassesOnColumn("TIP_POTEZA");


            Id(x => x.ID_turnira).Column("ID_TURNIRA").GeneratedBy.SequenceIdentity("S16032.SEQ_TURNIR");

            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Zemlja).Column("ZEMLJA");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Godina).Column("GODINA");
            Map(x => x.Trajanje).Column("TRAJANJE");

            HasMany(x => x.Partije).KeyColumn("ID_TURNIRA").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Organizatori)
                            .Table("ORGANIZUJE")
                            .ParentKeyColumn("ID_TURNIRA")
                            .ChildKeyColumn("ID_ORGANIZATORA")
                            .Inverse()
                            .Cascade.All();
            HasManyToMany(x => x.Sahisti)
                .Table("UCESTVUJE")
                .ParentKeyColumn("ID_TURNIRA")
                .ChildKeyColumn("ID_SAHISTE")
                .Inverse()
                .Cascade.All();
            


        }
    }

    public class TakmicarskiTurnirMapiranje : SubclassMap<TakmicarskiTurnir>
    {
        public TakmicarskiTurnirMapiranje()
        {
            Table("turnir");
            DiscriminatorValue("takmicarski");



        }
    }

    public class EgzibicioniTurnirMapiranje : SubclassMap<EgzibicioniTurnir>
    {
        public EgzibicioniTurnirMapiranje()
        {
            Table("TURNIR");
            DiscriminatorValue("Egzibicioni");

            Map(x => x.Tip_egzibicije).Column("TIP_EGZIBICIJE");
            Map(x => x.Namenjeno_za).Column("NAMENJENO_ZA");
            Map(x => x.Suma).Column("SUMA");


        }
    }

    public class NormalniTurnirMapiranje : SubclassMap<NormalniTurnir>
    {
        public NormalniTurnirMapiranje()
        {
            Table("TURNIR");
            DiscriminatorValue("Normalni");
        }
    }

    public class BrzopotezniTurnirMapiranje : SubclassMap<BrzopotezniTurnir>
    {
        public BrzopotezniTurnirMapiranje()
        {
            Table("TURNIR");
            DiscriminatorValue("Brzopotezni");
            

            Map(x => x.Max_vreme_trajanja).Column("MAX_VREME_TRAJANJA");
        }
    }



  
}
