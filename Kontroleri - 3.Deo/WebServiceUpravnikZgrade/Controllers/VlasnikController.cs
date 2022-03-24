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
    public class VlasnikController : ApiController
    {
        public IList<VlasnikViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetVlasnici();
        }
        public VlasnikViewModel Get(long mbr)
        {
            DataProvider provider = new DataProvider();
            VlasnikViewModel vlasnik = provider.GetVlasnik(mbr);
            return vlasnik;
        }
    }
}