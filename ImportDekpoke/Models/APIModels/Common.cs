namespace ImportDekpoke.Models.APIModels
{
    public class Category
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class EffectEntry
    {
        public string effect { get; set; }
        public Language language { get; set; }
        public string short_effect { get; set; }
    }
    public class FlavorTextEntry
    {
        public Language language { get; set; }
        public string text { get; set; }
        public VersionGroup version_group { get; set; }
    }
    public class GameIndex
    {
        public int game_index { get; set; }
        public Generation generation { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class Name
    {
        public Language language { get; set; }
        public string name { get; set; }
    }


    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
