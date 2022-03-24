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
    public class UpravnikController : ApiController
    {
        public IList<UpravnikViewModel> Get()
        {
            DataProvider dp = new DataProvider();
            return dp.GetUpravnici();
        }
        public UpravnikViewModel Get(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.GetUpravnik(mbr);
        }
        public int Post([FromBody]UpravnikViewModel uvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddUpravnik(uvm);
        }
        public int Put(long mbr, [FromBody]UpravnikViewModel uvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateUpravnik(mbr, uvm);
        }
        public int Delete(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteUpravnik(mbr);
        }
    }
}