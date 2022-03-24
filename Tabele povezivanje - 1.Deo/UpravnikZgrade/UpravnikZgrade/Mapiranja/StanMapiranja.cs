using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class StanMapiranja : ClassMap<Stan>
    {
        public StanMapiranja()
        {
            Table("STAN");

            Id(x => x.RedniBrojStana, "REDNI_BROJ_STANA").GeneratedBy.Assigned();

            Map(x => x.ImenaStanara).Column("IMENA_STANARA");
        }
    }
}
