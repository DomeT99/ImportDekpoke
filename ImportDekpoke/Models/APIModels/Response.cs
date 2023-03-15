namespace ImportDekpoke.Models.APIModels
{
    public class Response
    {
        public int count { get; set; }
        public string? next { get; set; }
        public object? previous { get; set; }
        public List<Result>? Results { get; set; }
    }
    public class Result
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
