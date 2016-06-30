using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Api
{
    internal static class Constants
    {
        internal static string ApiUrlBase = "https://b2vapi.bmwgroup.com/{0}";
        internal static string ApiActionEndpoint = "/webapi/v1/user/vehicles/{0}/executeService";
        internal static string ApiAllTripsEndpoint = "/webapi/v1/user/vehicles/{0}/statistics/allTrips";
        internal static string ApiChargingTimesEndpoint = "/webapi/v1/user/vehicles/{0}/chargingprofile";
        internal static string ApiLastTripEndpoint = "/webapi/v1/user/vehicles/{0}/statistics/lastTrip";
        internal static string ApiAuthEndpoint = "webapi/oauth/token/";
        internal static string ApiVehiclesEndpoint = "/webapi/v1/user/vehicles/";
        internal static string ApiVehicleStatusEndpoint = "/webapi/v1/user/vehicles/{0}/status";

        internal static string ActionServiceType = "serviceType";
        internal static string LockDoors = "DOOR_LOCK";
        internal static string UnlockDoors = "DOOR_UNLOCK";
        internal static string UpdateCharging = "CHARGING_CONTROL";
        internal static string WeeklyPlannerTimer = "WEEKLY_PLANNER_TIMER";
    }
}
