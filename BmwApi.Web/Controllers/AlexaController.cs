using BmwApi.Web.Alexa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AlexaSkillsKit;

namespace BmwApi.Web.Controllers
{
    public class AlexaController : ApiController
    {
        [HttpPost]
        [Route("api/alexa")]
        public HttpResponseMessage AlexaSession()
        {
            var speechlet = new AlexaRequest();
            return speechlet.GetResponse(Request);
        }
    }
}
