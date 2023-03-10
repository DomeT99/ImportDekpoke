using RestSharp;

namespace ImportDekpoke.Utils
{
    class Call
    {

        public static async Task<RestResponse> Get(string url)
        {
            try
            {
                using RestClient client = new();


                RestRequest request = new(url, Method.Get);

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
