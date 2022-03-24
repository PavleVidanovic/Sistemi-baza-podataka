using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class LicencaMapiranja : ClassMap<Licenca>
    {
        public LicencaMapiranja()
        {
            Table("LICENCA");

            Id(x => x.BrojLicence, "BROJ_LICENCE").GeneratedBy.Assigned();

            Map(x => x.DatumSticanja).Column("DATUM_STICANJA");
            Map(x => x.DatumObnove).Column("DATUM_OBNOVE");

            References(x => x.JeStekao).Column("MATICNI_BROJ3");
        }
    }
}
