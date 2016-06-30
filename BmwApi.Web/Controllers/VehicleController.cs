using System.Collections.Generic;
using System.Web.Http;

namespace BmwApi.Web.Controllers
{
    public class VehicleController : ApiController
    {
        [HttpGet]
        [Route("api/vehicle/alltrips")]
        public Core.Model.ApiAllTrips AllTrips()
        {
            return Core.Get.AllTrips;
        }

        [HttpGet]
        [Route("api/vehicle/lasttrip")]
        public Core.Model.ApiLastTrip LastTrip()
        {
            return Core.Get.LastTrip;
        }

        [HttpGet]
        [Route("api/vehicle/allvehicles")]
        public List<Core.Model.ApiVehicle> AllVehicles()
        {
            return Core.Get.Vehicles;
        }

        [HttpGet]
        [Route("api/vehicle/weeklyplanner")]
        public Core.Model.ApiWeeklyPlanner WeeklyPlanner()
        {
            return Core.Get.WeeklyPanner;
        }

        [HttpGet]
        [Route("api/vehicle/status")]
        public Core.Model.ApiVehicleStatus Status()
        {
            return Core.Get.Status;
        }
    }
}
