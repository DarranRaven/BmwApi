using BmwApi.Core.Account;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BmwApi.Core.Api
{
    internal abstract class ApiPost : ApiRequest
    {
        internal virtual Dictionary<string, string> PostData { get; }

        internal override string ApiEndpoint
        {
            get
            {
                return string.Format(Constants.ApiActionEndpoint, AccountSettings.Vin.Value);
            }
        }

        protected override Task<HttpResponseMessage> GetResponseAsync(HttpClient client)
        {
            var content = new FormUrlEncodedContent(PostData);
            return client.PostAsync(ApiUrl, content);
        }
    }
}
