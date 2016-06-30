using BmwApi.Core.Account;
using BmwApi.Core.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BmwApi.Core.Api
{
    internal class UserAccount : ApiPost
    {
        internal override Dictionary<string, string> PostData
        {
            get
            {
                return new Dictionary<string, string>
                    {
                       { "grant_type", "password" },
                       { "username", AccountSettings.Username.Value },
                       { "password", AccountSettings.Password.Value },
                       { "scope", "vehicle_data remote_services" }
                    };
            }
        }

        internal override string ApiEndpoint
        {
            get
            {
                return Constants.ApiAuthEndpoint;
            }
        }

        public string Token { get; set; }

        public UserAccount()
        {
            GetBearer();
        }

        private async void GetBearer()
        {
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiAuthorisationResponse>(await GetApiResponse());
            Token = response.Access_Token;
        }

        internal override void GetAuthenticationHeader(HttpClient client)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", AccountSettings.AuthenticationKey.Value);
        }
    }
}
