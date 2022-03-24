using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using FluentNHibernate.Mapping;

namespace UpravnikZgrade.Mapiranja
{
    public class OsobaMapiranja : ClassMap<Osoba>
    {
        public OsobaMapiranja()
        {
            Table("OSOBA");

            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.Assigned();

            Map(x => x.LicnoIme).Column("LICNO_IME");
            Map(x => x.ImeRoditelja).Column("IME_RODITELJA");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.BrojTelefona).Column("BROJTELEFONA");
            Map(x => x.Mesto).Column("MESTO");
            Map(x => x.Ulica).Column("ULICA");
        }
    }
}
