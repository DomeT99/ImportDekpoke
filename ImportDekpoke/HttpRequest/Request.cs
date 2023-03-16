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
        private static bool IsLoading { get; set; }

        public static void GetPokemon(string folderPath)
        {
            RequestParams parameters = new(StaticUrl!, "/pokemon/?limit=2");
            IsLoading = true;

            try
            {
                Thread loadingThread = new(() =>
                {
                    Spinner spinner = new();
                    while (IsLoading)
                    {
                        spinner.Turn();
                    }

                });
                Thread requestThread = new(async () =>
                {

                    if (Utility.CheckFolderPath(folderPath))
                    {
                        RestResponse? response = await Call.Get(parameters.Url + parameters.Path);

                        if (response.Content is not null && response.IsSuccessful)
                        {
                            PokemonApi? jsonPokeApi = JsonConvert.DeserializeObject<PokemonApi>(response.Content);

                            Converter.ToJson(jsonPokeApi?.Results!, folderPath, Choise.POKEMON);
                            IsLoading = false;
                        }
                    }
                    else
                    {
                        IsLoading = false;
                        Console.WriteLine("The path is invalid!");
                    }
                });

                loadingThread.Start();
                requestThread.Start();

                loadingThread.Join();
                requestThread.Join();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void GetMoves(string folderPath)
        {
            RequestParams parameters = new(StaticUrl!, "/move/?limit=2");
            IsLoading = true;

            try
            {
                Thread loadingThread = new(() =>
                {
                    Spinner spinner = new();
                    while (IsLoading)
                    {
                        spinner.Turn();
                    }

                });
                Thread requestThread = new(async () =>
                {
                    if (Utility.CheckFolderPath(folderPath))
                    {
                        RestResponse? response = await Call.Get(parameters.Url + parameters.Path);

                        if (response.Content is not null && response.IsSuccessful)
                        {
                            MoveApi? jsonMoveApi = JsonConvert.DeserializeObject<MoveApi>(response.Content);

                            Converter.ToJson(jsonMoveApi?.Results!, folderPath, Choise.MOVES);
                            IsLoading = false;
                        }
                    }
                    else
                    {
                        IsLoading = false;
                        Console.WriteLine("The path is invalid!");
                    }
                });

                loadingThread.Start();
                requestThread.Start();

                loadingThread.Join();
                requestThread.Join();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void GetItems(string folderPath)
        {
            RequestParams parameters = new(StaticUrl!, "/item/?limit=2");
            IsLoading = true;

            try
            {
                Thread loadingThread = new(() =>
                {
                    Spinner spinner = new();
                    while (IsLoading)
                    {
                        spinner.Turn();
                    }

                });
                Thread requestThread = new(async () =>
                {
                    if (Utility.CheckFolderPath(folderPath))
                    {
                        RestResponse? response = await Call.Get(parameters.Url + parameters.Path);

                        if (response.Content is not null && response.IsSuccessful)
                        {
                            ItemApi? jsonItemApi = JsonConvert.DeserializeObject<ItemApi>(response.Content);

                            Converter.ToJson(jsonItemApi?.Results!, folderPath, Choise.ITEMS);
                            IsLoading = false;
                        }
                    }
                    else
                    {
                        IsLoading = false;
                        Console.WriteLine("The path is invalid!");
                    }
                });


                loadingThread.Start();
                requestThread.Start();

                loadingThread.Join();
                requestThread.Join();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
