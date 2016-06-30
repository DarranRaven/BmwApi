using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Model
{
    public class ApiAllTripsResponse
    {
        public ApiAllTrips AllTrips { get; set; }
    }

    public class ApiAllTrips
    {
        public ApiAllTripsComparisson AvgElectricConsumption { get; set; }
        public ApiAllTripsComparisson AvgRecuperation { get; set; }
        public ApiAllTripsComparisson ChargecycleRange { get; set; }
        public ApiAllTripsComparisson TotalElectricDistance { get; set; }
        public ApiAllTripsComparisson AvgCombinedConsumption { get; set; }
        public decimal SavedCO2 { get; set; }
        public decimal SavedCO2greenEnergy { get; set; }
        public int TotalSavedFuel { get; set; }
        public DateTime ResetDate { get; set; }
    }

    public class ApiAllTripsComparisson
    {
        public decimal communityLow { get; set; }
        public decimal communityAverage { get; set; }
        public decimal communityHigh { get; set; }
        public decimal userAverage { get; set; }
        public decimal userHigh { get; set; }
        public decimal userTotal { get; set; }
        public decimal userCurrentChargeCycle { get; set; }
    }
}
