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
    public class UlazController : ApiController
    {
        public IList<UlazViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetUlazi();
        }
        public UlazViewModel Get(int rednibroj)
        {
            DataProvider provider = new DataProvider();
            UlazViewModel ulaz = provider.GetUlaz(rednibroj);
            return ulaz;
        }
        public int Post([FromBody]UlazViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddUlaz(zvm);
        }
        public int Put(int rednibroj, [FromBody]UlazViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateUlaz(rednibroj, zvm);
        }
        public int Delete(int rednibroj)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteUlaz(rednibroj);
        }
    }
}