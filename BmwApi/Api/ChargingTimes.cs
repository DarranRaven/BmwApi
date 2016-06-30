using BmwApi.Core.Account;
using BmwApi.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmwApi.Core.Api
{
    internal class ChargingTimes : ApiGet
    {
        public ApiWeeklyPlanner Planner { get; set; }

        public ChargingTimes()
        {
            GetChargingTimes();
        }

        private async void GetChargingTimes()
        {
            Planner = JsonConvert.DeserializeObject<ApiWeeklyPlannerResponse>(await GetApiResponse()).weeklyPlanner;
        }

        internal override string ApiEndpoint
        {
            get
            {
                return string.Format(Constants.ApiChargingTimesEndpoint, AccountSettings.Vin.Value);
            }
        }
    }
}
