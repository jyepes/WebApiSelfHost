using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace self_host_webapi
{
    public class DirectoriesController : ApiController
    {
        public string[] GetDirectories()
        {
            return System.IO.Directory.GetDirectories(@"C:\");
        }
    }
}
