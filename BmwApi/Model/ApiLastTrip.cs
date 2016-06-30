using System;

namespace BmwApi.Core.Model
{
    public class ApiLastTrip
    {
        public decimal EfficiencyValue { get; set; }
        public decimal TotalDistance { get; set; }
        public decimal ElectricDistance { get; set; }
        public decimal AvgElectricConsumption { get; set; }
        public decimal AvgRecuperation { get; set; }
        public int DrivingModeValue { get; set; }
        public decimal AccelerationValue { get; set; }
        public decimal AnticipationValue { get; set; }
        public decimal TotalConsumptionValue { get; set; }
        public decimal AuxiliaryConsumptionValue { get; set; }
        public decimal AvgCombinedConsumption { get; set; }
        public decimal ElectricDistanceRatio { get; set; }
        public decimal SavedFuel { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
    }
}