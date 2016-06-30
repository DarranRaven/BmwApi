using BmwApi.Core.Account;
using BmwApi.Core.Model;
using Newtonsoft.Json;

namespace BmwApi.Core.Api
{
    internal class VehicleStatus : ApiGet
    {
        public ApiVehicleStatus Status { get; set; }

        public VehicleStatus()
        {
            GetVehicleStatus();
        }

        private async void GetVehicleStatus()
        {
            Status = JsonConvert.DeserializeObject<ApiStatusResponse>(await GetApiResponse()).VehicleStatus;
        }

        internal override string ApiEndpoint
        {
            get
            {
                return string.Format(Constants.ApiVehicleStatusEndpoint, AccountSettings.Vin.Value);
            }
        }
    }
}
