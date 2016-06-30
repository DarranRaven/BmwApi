namespace BmwApi.Core.Api
{
    internal abstract class ActionBase : ApiPost
    {
        public ActionBase()
        {
            MakeRequest();
        }

        private async void MakeRequest()
        {
            await GetApiResponse();
        }
    }
}
