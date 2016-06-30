using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core
{
    public static class Get
    {
        public static List<Model.ApiVehicle> Vehicles { get { return new Api.Vehicles().CurrentVehicles; } }
        public static Model.ApiAllTrips AllTrips { get { return new Api.AllTrips().AllTripsData; } }
        public static Model.ApiWeeklyPlanner WeeklyPanner { get { return new Api.ChargingTimes().Planner; } }
        public static Model.ApiLastTrip LastTrip { get { return new Api.LastTrip().LastTripStats; } }
        public static Model.ApiVehicleStatus Status { get { return new Api.VehicleStatus().Status; } }
    }
}
