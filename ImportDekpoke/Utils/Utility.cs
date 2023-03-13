using Newtonsoft.Json;

namespace ImportDekpoke.Utils
{
    internal class Utility
    {
        public static bool CheckFolderPath(string folderPath)
        {
            if (folderPath != null && folderPath != string.Empty)
            {
                if (Directory.Exists(folderPath))
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }

        public static void SaveJson<T>(List<T> jsonList, string path, string name)
        {
            string json = JsonConvert.SerializeObject(jsonList.ToList());
            File.WriteAllText($"{path}\\{name}.json", json);

        }
    }
}
