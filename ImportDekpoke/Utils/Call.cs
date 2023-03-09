using RestSharp;

namespace ImportDekpoke.Utils
{
    class Call
    {
        private string Url { get; set; }
        public Call(string _url)
        {
            Url = _url;
        }

        public async Task<RestResponse> Get()
        {
            try
            {
                using RestClient client = new();


                RestRequest request = new(Url, Method.Get);

                RestResponse response = await client.GetAsync(request);

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
