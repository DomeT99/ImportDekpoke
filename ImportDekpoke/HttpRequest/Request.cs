using ImportDekpoke.Models.APIModels;
using ImportDekpoke.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace ImportDekpoke.HttpRequest
{
    class Request
    {
        private static readonly string? Url = "https://pokeapi.co/api/v2";

        public async static void GetPokemon()
        {
            try
            {
                Call call = new(Url + "/pokemon/?limit=2");

                RestResponse? result = await call.Get();

                if (result.Content is not null && result.IsSuccessful)
                {
                    PokemonApi? jsonPokeApi = JsonConvert.DeserializeObject<PokemonApi>(result.Content);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
