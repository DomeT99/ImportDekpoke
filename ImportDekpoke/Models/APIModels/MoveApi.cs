namespace ImportDekpoke.Models.APIModels
{
    #region ListMove
    public class MoveApi
    {
        public int count { get; set; }
        public string? next { get; set; }
        public object? previous { get; set; }
        public List<Result>? Results { get; set; }
    }
    #endregion



    public class Ailment
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class ContestCombos
    {
        public Normal normal { get; set; }
        public Super super { get; set; }
    }

    public class ContestEffect
    {
        public string url { get; set; }
    }

    public class ContestType
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class DamageClass
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
        public string flavor_text { get; set; }
        public Language language { get; set; }
        public VersionGroup version_group { get; set; }
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

    public class LearnedByPokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Meta
    {
        public Ailment ailment { get; set; }
        public int ailment_chance { get; set; }
        public Category category { get; set; }
        public int crit_rate { get; set; }
        public int drain { get; set; }
        public int flinch_chance { get; set; }
        public int healing { get; set; }
        public object max_hits { get; set; }
        public object max_turns { get; set; }
        public object min_hits { get; set; }
        public object min_turns { get; set; }
        public int stat_chance { get; set; }
    }

    public class Name
    {
        public Language language { get; set; }
        public string name { get; set; }
    }

    public class Normal
    {
        public object use_after { get; set; }
        public List<UseBefore> use_before { get; set; }
    }

    public class MoveDetails
    {
        public int accuracy { get; set; }
        public ContestCombos contest_combos { get; set; }
        public ContestEffect contest_effect { get; set; }
        public ContestType contest_type { get; set; }
        public DamageClass damage_class { get; set; }
        public object effect_chance { get; set; }
        public List<object> effect_changes { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public List<LearnedByPokemon> learned_by_pokemon { get; set; }
        public List<object> machines { get; set; }
        public Meta meta { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<object> past_values { get; set; }
        public int power { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public List<object> stat_changes { get; set; }
        public SuperContestEffect super_contest_effect { get; set; }
        public Target target { get; set; }
        public Type type { get; set; }
    }

    public class Super
    {
        public object use_after { get; set; }
        public object use_before { get; set; }
    }

    public class SuperContestEffect
    {
        public string url { get; set; }
    }

    public class Target
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class UseBefore
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }


}
