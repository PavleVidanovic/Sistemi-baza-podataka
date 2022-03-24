using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class LiftMapiranja : ClassMap<Lift>
    {
        public LiftMapiranja()
        {
            Table("LIFT");

            Id(x => x.SerijskiBroj, "SERIJSKI_BROJ").GeneratedBy.Assigned();

            Map(x => x.NazivProizvodjaca).Column("NAZIV_PROIZVODJACA");
            Map(x => x.DatumPoslednjegKvara).Column("DATUM_POSLEDNJEG_KVARA");
            Map(x => x.DatumPoslednjegServisiranja).Column("DATUM_POSLEDNJEG_SERVISIRANJA");
            Map(x => x.BrojPokvarenihDana).Column("BROJ_POKVARENIH_DANA");

            References(x => x.PripadaZgradi).Column("REDNI_BROJ5").LazyLoad();
        }
    }
}