using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ServerUpController : ApiController
    {
        [ActionName("Serverup")]
        public IHttpActionResult GetServerUp()
        {
            return Ok();
        }
    }
}
