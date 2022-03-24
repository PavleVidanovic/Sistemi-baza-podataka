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
    public class BlagajnikController : ApiController
    {
        public IList<BlagajnikViewModel> Get()
        {
            DataProvider dp = new DataProvider();
            return dp.GetBlagajnici();
        }
        public BlagajnikViewModel Get(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.GetBlagajnik(mbr);
        }
        public int Post([FromBody]BlagajnikViewModel bvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddBlagajnik(bvm);
        }
        public int Put(long mbr, [FromBody]BlagajnikViewModel bvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateBlagajnik(mbr, bvm);
        }
        public int Delete(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteBlagajnik(mbr);
        }
    }
}