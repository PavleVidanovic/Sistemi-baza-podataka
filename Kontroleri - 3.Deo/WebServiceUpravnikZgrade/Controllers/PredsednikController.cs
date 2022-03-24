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
    public class PredsednikController : ApiController
    {
        public IList<PredsednikViewModel> Get()
        {
            DataProvider dp = new DataProvider();
            return dp.GetPredsednici();
        }
        public PredsednikViewModel Get(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.GetPredsednik(mbr);
        }
        public int Post([FromBody]PredsednikViewModel pvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddPredsednik(pvm);
        }
        public int Put(long mbr, [FromBody]PredsednikViewModel pvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdatePredsednik(mbr, pvm);
        }
        public int Delete(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.DeletePredsednik(mbr);
        }
    }
}