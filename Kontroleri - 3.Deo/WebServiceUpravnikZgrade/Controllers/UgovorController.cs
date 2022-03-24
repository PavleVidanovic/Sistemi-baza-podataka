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
    public class UgovorController : ApiController
    {
        public IList<UgovorViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetUgovori();
        }
        public UgovorViewModel Get(int sifra)
        {
            DataProvider provider = new DataProvider();
            UgovorViewModel ugovor = provider.GetUgovor(sifra);
            return ugovor;
        }
        public int Post([FromBody]UgovorViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddUgovor(zvm);
        }
        public int Put(int sifra, [FromBody]UgovorViewModel zvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateUgovor(sifra, zvm);
        }
        public int Delete(int sifra)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteUgovor(sifra);
        }
    }
}