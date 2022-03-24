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
    public class TeretniController : ApiController
    {
        public IList<TeretniViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetTeretne();
        }
        public TeretniViewModel Get(int serijskibroj)
        {
            DataProvider provider = new DataProvider();
            TeretniViewModel teretni = provider.GetTeretni(serijskibroj);
            return teretni;
        }
        public int Post([FromBody]TeretniViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddTeretni(zvm);
        }
        public int Put(int serijskibroj, [FromBody]TeretniViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateTeretni(serijskibroj, zvm);
        }
        public int Delete(int serijskibroj)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteTeretni(serijskibroj);
        }
    }
}