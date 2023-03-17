namespace ImportDekpoke.Models.APIModels
{

    public class Attribute
    {
        public string name { get; set; }
        public string url { get; set; }
    }


    public class ItemDetails
    {
        public List<Attribute> attributes { get; set; }
        public object baby_trigger_for { get; set; }
        public Category category { get; set; }
        public int cost { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public object fling_effect { get; set; }
        public object fling_power { get; set; }
        public List<GameIndex> game_indices { get; set; }
        public List<object> held_by_pokemon { get; set; }
        public int id { get; set; }
        public List<object> machines { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public SpritesItem sprites { get; set; }
    }

    public class SpritesItem
    {
        public string Default { get; set; }
    }



}
