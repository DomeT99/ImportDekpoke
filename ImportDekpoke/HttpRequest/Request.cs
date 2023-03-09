using ImportDekpoke.Utils;
using RestSharp;

namespace ImportDekpoke.HttpRequest
{
    class Request
    {
        private static readonly string? Url = "https://pokeapi.co/api/v2";
        
        public async static Task<RestResponse> GetPokemon()
        {
            try
            {
                Call call = new(Url + "/pokemon/");

                RestResponse? result = await call.Get();
                Console.WriteLine(result.Content);

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
