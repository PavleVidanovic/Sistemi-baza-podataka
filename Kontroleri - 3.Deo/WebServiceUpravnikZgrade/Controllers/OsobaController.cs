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
    public class OsobaController : ApiController
    {
        public IList<OsobaViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetOsobe();
        }
        public OsobaViewModel Get(long mbr)
        {
            DataProvider provider = new DataProvider();
            OsobaViewModel osoba = provider.GetOsoba(mbr);
            return osoba;
        }
    }
}