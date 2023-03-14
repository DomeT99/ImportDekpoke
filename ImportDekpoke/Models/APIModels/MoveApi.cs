namespace ImportDekpoke.Models.APIModels
{
    public class MoveApi
    {
        public int count { get; set; }
        public string? next { get; set; }
        public object? previous { get; set; }
        public List<Result>? Results { get; set; }
    }
}
