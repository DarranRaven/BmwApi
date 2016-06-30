using BmwApi.Core.Account;
using BmwApi.Core.Model;
using Newtonsoft.Json;

namespace BmwApi.Core.Api
{
    internal class LastTrip : ApiGet
    {
        public ApiLastTrip LastTripStats { get; set; }

        public LastTrip()
        {
            GetLastTrip();
        }

        private async void GetLastTrip()
        {
            LastTripStats = JsonConvert.DeserializeObject<ApiLastTripResponse>(await GetApiResponse()).LastTrip;
        }

        internal override string ApiEndpoint
        {
            get
            {
                return string.Format(Constants.ApiLastTripEndpoint, AccountSettings.Vin.Value);
            }
        }
    }
}
