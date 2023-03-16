using ImportDekpoke.Models;
using ImportDekpoke.Models.APIModels;
using ImportDekpoke.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace ImportDekpoke.HttpRequest
{
    class Request
    {
        private static readonly string? StaticUrl = "https://pokeapi.co/api/v2";

        public async static void GetPokemon(string folderPath)
        {
            RequestParams parameters = new(StaticUrl!, "/pokemon/?limit=2");

            try
            {


                if (Utility.CheckFolderPath(folderPath))
                {
                    RestResponse? response = await Call.Get(parameters.Url + parameters.Path);

                    if (response.Content is not null && response.IsSuccessful)
                    {
                        PokemonApi? jsonPokeApi = JsonConvert.DeserializeObject<PokemonApi>(response.Content);

                        Converter.ToJson(jsonPokeApi?.Results!, folderPath, Choise.POKEMON);

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

        public async static void GetMoves(string folderPath)
        {
            RequestParams parameters = new(StaticUrl!, "/move/?limit=2");


            try
            {
                if (Utility.CheckFolderPath(folderPath))
                {
                    RestResponse? response = await Call.Get(parameters.Url + parameters.Path);

                    if (response.Content is not null && response.IsSuccessful)
                    {
                        MoveApi? jsonMoveApi = JsonConvert.DeserializeObject<MoveApi>(response.Content);

                        Converter.ToJson(jsonMoveApi?.Results!, folderPath, Choise.MOVES);
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

        public async static void GetItems(string folderPath)
        {
            RequestParams parameters = new(StaticUrl!, "/item/?limit=2");


            try
            {
                if (Utility.CheckFolderPath(folderPath))
                {
                    RestResponse? response = await Call.Get(parameters.Url + parameters.Path);

                    if (response.Content is not null && response.IsSuccessful)
                    {
                        ItemApi? jsonItemApi = JsonConvert.DeserializeObject<ItemApi>(response.Content);

                        Converter.ToJson(jsonItemApi?.Results!, folderPath, Choise.ITEMS);
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
