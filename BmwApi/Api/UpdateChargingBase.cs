using BmwApi.Core.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BmwApi.Core.Api
{
    internal abstract class UpdateChargingBase : ActionBase
    {
        protected abstract bool SetOffPeakCharging { get; }

        internal override Dictionary<string, string> PostData
        {
            get
            {
                { return new Dictionary<string, string> {
                    { Constants.ActionServiceType, Constants.UpdateCharging },
                    { "data", JsonConvert.SerializeObject(new ApiUpdateCharging(new ChargingTimes().Planner, SetOffPeakCharging))}
                }; }
            }
        }
    }
}
