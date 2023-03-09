namespace ImportDekpoke.Models.APIModels
{
    
    public class Result
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class PokemonApi
    {
        public int Count { get; set; }
        public List<Result>? Results { get; set; }
    }
}
