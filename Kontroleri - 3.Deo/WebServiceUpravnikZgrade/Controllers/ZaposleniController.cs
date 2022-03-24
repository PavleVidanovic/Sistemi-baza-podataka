using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UpravnikZgrade;
using UpravnikZgrade.Entiteti;


namespace WebServiceUpravnikZgrade.Controllers
{
    public class ZaposleniController : ApiController
    {
        public ZaposleniViewModel Get(long mbr)
        {
            DataProvider provider = new DataProvider();
            ZaposleniViewModel zap = provider.GetZaposleni(mbr);
            return zap;
        }
        public IList<ZaposleniViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetZaposlene();
        }

    }
}