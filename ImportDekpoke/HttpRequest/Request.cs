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
       
        public static void GetData(string folderPath, string path, Choise choise)
        {
            RequestParams parameters = new(StaticUrl!, path);
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

                            Response? jsonApi = JsonConvert.DeserializeObject<Response>(response.Content);

                            Converter.ToJson(jsonApi?.Results!, folderPath, choise);
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
