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
    public class ClanSavetaController : ApiController
    {
        public IList<ClanSavetaViewModel> Get()
        {
            DataProvider dp = new DataProvider();
            return dp.GetClanoviSaveta();
        }
        public ClanSavetaViewModel Get(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.GetClanSaveta(mbr);
        }
        public int Post([FromBody]ClanSavetaViewModel csvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddClanSaveta(csvm);
        }
        public int Put(long mbr, [FromBody]ClanSavetaViewModel csvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateClanSaveta(mbr, csvm);
        }
        public int Delete(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteClanSaveta(mbr);
        }
    }
}