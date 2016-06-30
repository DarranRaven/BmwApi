using BmwApi.Core.Api;
using System.Collections.Generic;
using System.Linq;

namespace BmwApi.Core.Model
{
    public class ApiUpdateCharging
    {
        public ApiUpdateCharging(ApiWeeklyPlanner planner, bool enableOffPeakCharging)
        {
            var allTimers = new List<ApiTimer> { planner.timer1, planner.timer2, planner.timer3 };
            if (enableOffPeakCharging && !allTimers.Any(timer => timer.timerEnabled))
            {
                planner.timer1.timerEnabled = true;
            }

            weeklyPlanner = new ApiUpdateChargingData
            {
                climatizationEnabled = planner.climatizationEnabled,
                preferredChargingWindow = planner.preferredChargingWindow,
                timer1 = planner.timer1,
                timer2 = planner.timer2,
                timer3 = planner.timer3,
                timers = allTimers,
                overrideTimer = new ApiUpdateChargingOverrideTimer()
            };
        
            weeklyPlanner.preferredChargingWindow.enabled = enableOffPeakCharging;
        }
        public ApiUpdateChargingData weeklyPlanner { get; set; }
    }

    public class ApiUpdateChargingData
    {
        public string mChargingProfileType { get { return Constants.WeeklyPlannerTimer; } }
        public bool climatizationEnabled { get; set; }
        public ApiUpdateChargingOverrideTimer overrideTimer { get; set; }
        public ApiChargingWindow preferredChargingWindow { get; set; }
        public ApiTimer timer1 { get; set; }
        public ApiTimer timer2 { get; set; }
        public ApiTimer timer3 { get; set; }
        public List<ApiTimer> timers { get; set; }
    }

    public class ApiUpdateChargingOverrideTimer
    {
        public bool timerEnabled { get { return false; } }
        public List<string> weekdays { get { return new List<string>(); } }
    }
}
