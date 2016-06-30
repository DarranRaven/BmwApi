using System.Net.Http;
using System.Threading.Tasks;

namespace BmwApi.Core.Api
{
    internal abstract class ApiGet : ApiRequest
    {
        protected override Task<HttpResponseMessage> GetResponseAsync(HttpClient client)
        {
            return client.GetAsync(ApiUrl);
        }
    }
}
