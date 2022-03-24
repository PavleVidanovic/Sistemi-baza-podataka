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
    public class NiziController : ApiController
    {
        public IList<SpratNiziViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetNize();
        }
        public SpratNiziViewModel Get(int nivo)
        {
            DataProvider provider = new DataProvider();
            SpratNiziViewModel nizi = provider.GetNizi(nivo);
            return nizi;
        }
        public int Post([FromBody]SpratNiziViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddNizi(zvm);
        }
        public int Put(int nivo, [FromBody]SpratNiziViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateNizi(nivo, zvm);
        }
        public int Delete(int nivo)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteNizi(nivo);
        }
    }
}