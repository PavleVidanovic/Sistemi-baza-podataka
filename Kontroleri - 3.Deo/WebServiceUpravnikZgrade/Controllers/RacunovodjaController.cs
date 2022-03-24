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
    public class RacunovodjaController : ApiController
    {
        public IList<RacunovodjaViewModel> Get()
        {
            DataProvider dp = new DataProvider();
            return dp.GetRacunovodje();
        }
        public RacunovodjaViewModel Get(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.GetRacunovodja(mbr);
        }
        public int Post([FromBody]RacunovodjaViewModel rvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddRacunovodja(rvm);
        }
        public int Put(long mbr, [FromBody]RacunovodjaViewModel rvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateRacunovodja(mbr, rvm);
        }
        public int Delete(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteRacunovodja(mbr);
        }
    }
}