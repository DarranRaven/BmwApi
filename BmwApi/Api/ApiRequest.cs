using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BmwApi.Core.Api
{
    internal abstract class ApiRequest
    {
        internal abstract string ApiEndpoint { get; }

        protected string ApiUrl { get { return string.Format(Constants.ApiUrlBase, ApiEndpoint); } }

        internal virtual void GetAuthenticationHeader(HttpClient client){
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", new UserAccount().Token);
        }

        protected Task<string> GetApiResponse()
        {
            using (var client = new HttpClient())
            {
                GetAuthenticationHeader(client);

                var response = GetResponseAsync(client);
                return response.Result.Content.ReadAsStringAsync();
            }
        }

        protected abstract Task<HttpResponseMessage> GetResponseAsync(HttpClient client);
    }
}
