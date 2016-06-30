using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Model
{
    public class ApiWeeklyPlannerResponse
    {
        public ApiWeeklyPlanner weeklyPlanner { get; set; }
    }

    public class ApiWeeklyPlanner
    {
        public bool climatizationEnabled { get; set; }
        public string chargingMode { get; set; }
        public string chargingPreferences { get; set; }
        public ApiTimer timer1 { get; set; }
        public ApiTimer timer2 { get; set; }
        public ApiTimer timer3 { get; set; }
        public ApiTimer overrideTimer { get; set; }
        public ApiChargingWindow preferredChargingWindow { get; set; }
    }
}
