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
    public class LiftController : ApiController
    {
        public IList<LiftViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetLiftovi();
        }
        public LiftViewModel Get(int rednibroj)
        {
            DataProvider provider = new DataProvider();
            LiftViewModel lift = provider.GetLift(rednibroj);
            return lift;
        }
    }
}