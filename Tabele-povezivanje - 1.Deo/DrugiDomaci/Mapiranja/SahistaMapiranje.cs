using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugiDomaci.Entiteti;
using FluentNHibernate.Mapping;

namespace DrugiDomaci.Mapiranja
{
    public class SahistaMapiranje : ClassMap<DrugiDomaci.Entiteti.Sahista>
    {
        public SahistaMapiranje()
        {
            Table("SAHISTA");
            DiscriminateSubClassesOnColumn("KATEGORIJA");
            Id(x => x.Registracioni_broj).Column("REGISTRACIONI_BROJ").GeneratedBy.SequenceIdentity("S16032.SEQ_SAHISTA");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Broj_pasosa).Column("BROJ_PASOSA");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Zemlja).Column("ZEMLJA");
            Map(x => x.Datum_rodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Datum_uclanjenja).Column("DATUM_UCLANJENJA");

            HasMany(x=>x.CrniBio).KeyColumn("ID_CRNOG").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.BeliBio).KeyColumn("ID_BELOG").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.UcestvovaoNaTurnirima)
                .Table("UCESTVUJE")
                .ParentKeyColumn("ID_SAHISTE")
                .ChildKeyColumn("ID_TURNIRA")
                .Cascade.All();

        }
    }

    public class MajstorMapiranje : SubclassMap<Entiteti.Majstor>
    {
        public MajstorMapiranje()
        {
            Table("SAHISTA");
            DiscriminatorValue("majstor");


            Map(x => x.Datum_sticanja).Column("DATUM_STICANJA_ZVANJA");

        }
    }
    public class MKMapiranje : SubclassMap<Entiteti.MK>
    {
        public MKMapiranje()
        {
            Table("SAHISTA");
            DiscriminatorValue("MK");

            Map(x => x.Broj_partija_do_majstora).Column("BROJ_PARTIJA_DO_MAJSTORA");

        }
    }

    public class ObicanMapiranje : SubclassMap<Entiteti.Obican>
    {
        public ObicanMapiranje()
        {
            Table("SAHISTA");
            DiscriminatorValue("obican");
        }
    }



}

