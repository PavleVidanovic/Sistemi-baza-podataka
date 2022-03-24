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
    public class VisiController : ApiController
    {
        public IList<SpratVisiViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetVise();
        }
        public SpratVisiViewModel Get(int nivo)
        {
            DataProvider provider = new DataProvider();
            SpratVisiViewModel visi = provider.GetVisi(nivo);
            return visi;
        }
        public int Post([FromBody]SpratVisiViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddVisi(zvm);
        }
        public int Put(int nivo, [FromBody]SpratVisiViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateVisi(nivo, zvm);
        }
        public int Delete(int nivo)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteVisi(nivo);
        }
    }
}