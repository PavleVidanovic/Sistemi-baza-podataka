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
    public class SekretarController : ApiController
    {
        public IList<SekretarViewModel> Get()
        {
            DataProvider dp = new DataProvider();
            return dp.GetSekretari();
        }
        public SekretarViewModel Get(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.GetSekretar(mbr);
        }
        public int Post([FromBody]SekretarViewModel svm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddSekretar(svm);
        }
        public int Put(long mbr, [FromBody]SekretarViewModel svm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateSekretar(mbr, svm);
        }
        public int Delete(long mbr)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteSekretar(mbr);
        }
    }
}