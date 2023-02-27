namespace ImportDekpoke.Models
{
    class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Base_Experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Statistics>? Stats { get; set; }
        public Sprite? Sprites { get; set; }
        public List<Type>? Types { get; set; }
    }

    class Statistics
    {
        public string? Name { get; set; }
        public int Base_Stat { get; set; }
    }

    class Sprite
    {
        public string? Front_Default { get; set; }
        public string? Front_Shiny { get; set; }
    }

    class Type : ISlotName
    {
        public int Slot { get; set; }
        public string? Name { get; set; }
    }

    class Ability : ISlotName
    {
        public string? Name { get; set; }
        public int Slot { get; set; }
        public bool? Is_Hidden { get; set; }
    }

    interface ISlotName
    {
        public string? Name { get; set; }
        public int Slot { get; set; }

    }
}
