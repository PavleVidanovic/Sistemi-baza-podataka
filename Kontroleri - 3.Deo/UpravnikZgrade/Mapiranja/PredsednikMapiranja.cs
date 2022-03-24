using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class PredsednikMapiranja : SubclassMap<Predsednik>
    {
        public PredsednikMapiranja()
        {
            Table("PREDSEDNIK");
            KeyColumn("MATICNI_BROJ");
        }
    }
}
