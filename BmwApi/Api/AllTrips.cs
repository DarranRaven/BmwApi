using BmwApi.Core.Account;
using BmwApi.Core.Model;
using Newtonsoft.Json;

namespace BmwApi.Core.Api
{
    internal class AllTrips : ApiGet
    {
        public ApiAllTrips AllTripsData { get; set; }

        public AllTrips()
        {
            GetAllTrips();
        }

        internal async void GetAllTrips()
        {
            AllTripsData = JsonConvert.DeserializeObject<ApiAllTripsResponse>(await GetApiResponse()).AllTrips;
        }

        internal override string ApiEndpoint
        {
            get
            {
                return string.Format(Constants.ApiAllTripsEndpoint, AccountSettings.Vin.Value);
            }
        }
    }
}
