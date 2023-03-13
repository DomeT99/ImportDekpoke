using ImportDekpoke.Models.APIModels;
using ImportDekpoke.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace ImportDekpoke.HttpRequest
{
    class Request
    {

        private static readonly string? Url = "https://pokeapi.co/api/v2";

        public async static void GetPokemon(string folderPath)
        {

            try
            {
                if (Utility.CheckFolderPath(folderPath))
                {
                    RestResponse? response = await Call.Get(Url + "/pokemon/?limit=2");

                    if (response.Content is not null && response.IsSuccessful)
                    {
                        PokemonApi? jsonPokeApi = JsonConvert.DeserializeObject<PokemonApi>(response.Content);

                        Converter.ToJsonPokemon(jsonPokeApi?.Results!, folderPath);
                    }
                }
                else
                {
                    Console.WriteLine("The path is invalid!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
