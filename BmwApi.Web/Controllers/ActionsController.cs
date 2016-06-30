using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BmwApi.Web.Controllers
{
    public class ActionsController : ApiController
    {
        [HttpPut]
        [Route("api/action/unlock")]
        public void Unlock() => Core.Post.UnlockDoors();

        [HttpPut]
        [Route("api/action/lock")]
        public void Lock() => Core.Post.LockDoors();

        [HttpPut]
        [Route("api/vehicle/enableoffpeakcharging")]
        public void EnableOffPeakCharging() => Core.Post.EnableOffPeakCharging();

        [HttpPut]
        [Route("api/vehicle/disableoffpeakcharging")]
        public void DisableOffPeakCharging() => Core.Post.DisableOffPeakCharging();
    }
}
