using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UpravnikZgrade;
using UpravnikZgrade.Entiteti;


namespace WebServiceUpravnikZgrade.Controllers
{
    public class SpratController : ApiController
    {
        public IList<SpratViewModel> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetSpratovi();
        }
        public SpratViewModel Get(int rednibroj)
        {
            DataProvider provider = new DataProvider();
            SpratViewModel sprat = provider.GetSprat(rednibroj);
            return sprat;
        }
    }
}