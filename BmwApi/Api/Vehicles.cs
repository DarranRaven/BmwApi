using BmwApi.Core.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BmwApi.Core.Api
{
    internal class Vehicles : ApiGet
    {
        public List<ApiVehicle> CurrentVehicles { get; set; }

        public Vehicles()
        {
            GetVehicles();
        }

        private async void GetVehicles()
        {
            CurrentVehicles = JsonConvert.DeserializeObject<ApiVehiclesResponse>(await GetApiResponse()).Vehicles;
        }

        internal override string ApiEndpoint
        {
            get
            {
                return Constants.ApiVehiclesEndpoint;
            }
        }
    }
}
