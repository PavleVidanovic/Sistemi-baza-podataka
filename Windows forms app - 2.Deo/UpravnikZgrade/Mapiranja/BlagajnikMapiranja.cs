using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class BlagajnikMapiranja : SubclassMap<Blagajnik>
    {
        public BlagajnikMapiranja()
        {
            Table("BLAGAJNIK");
            KeyColumn("MATICNI_BROJ");
        }
    }
}
