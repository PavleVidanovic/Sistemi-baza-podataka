using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class PrevozniMapiranja : SubclassMap<Prevozni>
    {
        public PrevozniMapiranja()
        {
            Table("PREVOZNI");
            KeyColumn("SERIJSKI_BROJ");
            Map(x => x.MaxOsoba).Column("MAX_OSOBA");
        }
    }
}
