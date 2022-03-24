using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class ClanSavetaMapiranja : SubclassMap<ClanSaveta>
    {
        public ClanSavetaMapiranja()
        {
            Table("CLAN_SAVETA");
            KeyColumn("MATICNI_BROJ");
        }
    }
}
