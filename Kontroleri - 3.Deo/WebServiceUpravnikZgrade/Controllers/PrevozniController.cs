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
    public class PrevozniController : ApiController
    {
        public IList<PrevozniViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetPrevozne();
        }
        public PrevozniViewModel Get(int serijskibroj)
        {
            DataProvider provider = new DataProvider();
            PrevozniViewModel prevozni = provider.GetPrevozni(serijskibroj);
            return prevozni;
        }
        public int Post([FromBody]PrevozniViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddPrevozni(zvm);
        }
        public int Put(int serijskibroj, [FromBody]PrevozniViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdatePrevozni(serijskibroj, zvm);
        }
        public int Delete(int serijskibroj)
        {
            DataProvider dp = new DataProvider();
            return dp.DeletePrevozni(serijskibroj);
        }
    }
}