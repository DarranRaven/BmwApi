using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Model
{

    public class ApiStatusResponse
    {
        public ApiVehicleStatus VehicleStatus { get; set; }

    }

    public class ApiVehicleStatus
    {
        public string Vin { get; set; }
        public int Mileage { get; set; }
        public string UpdateReason { get; set; }
        public DateTime UpdateTime { get; set; }
        public string DoorDriverFront { get; set; }
        public string DoorDriverRear { get; set; }
        public string DoorPassengerFront { get; set; }
        public string DoorPassengerRear { get; set; }
        public string WindowDriverFront { get; set; }
        public string WindowDriverRear { get; set; }
        public string WindowPassengerFront { get; set; }
        public string WindowPassengerRear { get; set; }
        public string Trunk { get; set; }
        public string RearWindow { get; set; }
        public string ConvertibleRoofState { get; set; }
        public string Hood { get; set; }
        public string DoorLockState { get; set; }
        public string ParkingLight { get; set; }
        public string PositionLight { get; set; }
        public string RemainingFuel { get; set; }
        public string RemainingRangeElectric { get; set; }
        public string RemainingRangeElectricMls { get; set; }
        public string RemainingRangeFuel { get; set; }
        public string RemainingRangeFuelMls { get; set; }
        public string MaxRangeElectric { get; set; }
        public string MaxRangeElectricMls { get; set; }
        public string FuelPercent { get; set; }
        public string MaxFuel { get; set; }
        public string ConnectionStatus { get; set; }
        public string ChargingStatus { get; set; }
        public int ChargingTimeRemaining { get; set; }
        public int ChargingLevelHv { get; set; }
        public string LastChargingEndReason { get; set; }
        public string LastChargingEndResult { get; set; }
        public ApiVehiclePosition Position { get; set; }
        public DateTime InternalDataTimeUTC { get; set; }
    }

    public class ApiVehiclePosition
    {
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public int Heading { get; set; }
        public string Status { get; set; }
    }

}
