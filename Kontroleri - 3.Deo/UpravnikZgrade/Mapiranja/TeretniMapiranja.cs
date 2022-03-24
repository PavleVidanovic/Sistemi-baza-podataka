using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class TeretniMapiranja : SubclassMap<Teretni>
    {
        public TeretniMapiranja()
        {
            Table("TERETNI");
            KeyColumn("SERIJSKI_BROJ");
            Map(x => x.Nosivost).Column("NOSIVOST");
        }
    }
}
