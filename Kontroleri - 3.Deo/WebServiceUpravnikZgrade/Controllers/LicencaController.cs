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
    public class LicencaController : ApiController
    {
        public IList<LicencaViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetLicence();
        }
        public LicencaViewModel Get(int brojlicence)
        {
            DataProvider provider = new DataProvider();
            LicencaViewModel licenca = provider.GetLicenca(brojlicence);
            return licenca;
        }
        public int Post([FromBody]LicencaViewModel lvm)
        {
            DataProvider dp = new DataProvider();
            return dp.AddLicenca(lvm);
        }
        public int Put(int brojlicence, [FromBody]LicencaViewModel lvm)
        {
            DataProvider dp = new DataProvider();
            return dp.UpdateLicenca(brojlicence, lvm);
        }
        public int Delete(int brojlicence)
        {
            DataProvider dp = new DataProvider();
            return dp.DeleteLicenca(brojlicence);
        }
    }
}