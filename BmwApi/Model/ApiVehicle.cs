using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Model
{
    public class ApiVehicle
    {
        public string Remote360 { get; set; }
        public string ChargingControl { get; set; }
        public string CountryCode { get; set; }
        public string HornBlow { get; set; }
        public string Brand { get; set; }
        public string SmartSolution { get; set; }
        public bool HasAlarmSystem { get; set; }
        public string ClimateControl { get; set; }
        public string DoorUnlock { get; set; }
        public string RangeMap { get; set; }
        public string ClimateFunction { get; set; }
        public string IscType { get; set; }
        public string Hub { get; set; }
        public bool StatisticsAvailable { get; set; }
        public string DoorLock { get; set; }
        public string IntermodalRouting { get; set; }
        public string Model { get; set; }
        public string VehicleFinder { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public string Bodytype { get; set; }
        public string ChargeNow { get; set; }
        public List<string> SupportedChargingModes { get; set; }
        public string SendPoi { get; set; }
        public int YearOfConstruction { get; set; }
        public string ClimateNow { get; set; }
        public string LightFlash { get; set; }
        public string DriveTrain { get; set; }
        public string LicensePlate { get; set; }
        public bool StatisticsCommunityEnabled { get; set; }
        public string ColorCode { get; set; }
        public string OnlineSearchMode { get; set; }
        public ApiAddress Dealer { get; set; }
        public string LastDestinations { get; set; }

    }
}
