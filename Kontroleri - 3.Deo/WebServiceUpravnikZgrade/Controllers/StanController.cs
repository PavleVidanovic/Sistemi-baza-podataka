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
    public class StanController : ApiController
    {
        public IList<StanViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetStanovi();
        }
        public StanViewModel Get(int rednibrojstana)
        {
            DataProvider provider = new DataProvider();
            StanViewModel stan = provider.GetStan(rednibrojstana);
            return stan;
        }
        public int Post([FromBody]StanViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddStan(zvm);
        }
        public int Put(int rednibrojstana, [FromBody]StanViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateStan(rednibrojstana, zvm);
        }
        public int Delete(int rednibrojstana)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteStan(rednibrojstana);
        }
    }
}