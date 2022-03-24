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
    public class ZgradaController : ApiController
    {
        public IList<ZgradaViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetZgrade();
        }
        public ZgradaViewModel Get(int rednibroj)
        {
            DataProvider provider = new DataProvider();
            ZgradaViewModel zgrada = provider.GetZgrada(rednibroj);
            return zgrada;
        }
        public int Post([FromBody]ZgradaViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddZgrada(zvm);
        }
        public int Put(int rednibroj, [FromBody]ZgradaViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateZgrada(rednibroj, zvm);
        }
        public int Delete(int rednibroj)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteZgrada(rednibroj);
        }
    }
}