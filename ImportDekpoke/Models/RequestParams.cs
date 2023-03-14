using System.Text.RegularExpressions;

namespace ImportDekpoke.Models
{
    class RequestParams
    {
        public string? Url { get; set; }
        public string? Path { get; set; }
        public RequestParams(string _url, string _path)
        {
            Regex urlRegex = new("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
           
            if (urlRegex.IsMatch(_url))
                Url = _url;
            else
                throw new ArgumentException("Url not valid!");

            Path = _path;
        }
    }
}
