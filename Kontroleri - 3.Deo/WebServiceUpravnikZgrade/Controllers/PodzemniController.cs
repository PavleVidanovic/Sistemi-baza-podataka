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
    public class PodzemniController : ApiController
    {
        public IList<SpratPodzemniViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetPodzemne();
        }
        public SpratPodzemniViewModel Get(int nivo)
        {
            DataProvider provider = new DataProvider();
            SpratPodzemniViewModel podzemni = provider.GetPodzemni(nivo);
            return podzemni;
        }
        public int Post([FromBody]SpratPodzemniViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddPodzemni(zvm);
        }
        public int Put(int nivo, [FromBody]SpratPodzemniViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdatePodzemni(nivo, zvm);
        }
        public int Delete(int nivo)
        {
            DataProvider dp = new DataProvider();
            return dp.DeletePodzemni(nivo);
        }
    }
}