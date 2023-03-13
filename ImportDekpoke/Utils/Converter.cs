using ImportDekpoke.Models;
using ImportDekpoke.Models.APIModels;
using Newtonsoft.Json;
using RestSharp;

namespace ImportDekpoke.Utils
{
    class Converter
    {
        public async static void ToJsonPokemon(List<Result> jsonPokeApi)
        {
            List<Pokemon> pokemons = new();
            RestResponse response = new();


            try
            {
                foreach (Result? counterPokeApi in jsonPokeApi)
                {

                    response = await Call.Get(counterPokeApi.Url!);

                    PokemonDetails? pokemonDetails = JsonConvert.DeserializeObject<PokemonDetails>(response.Content!);


                    Pokemon pokemon = new()
                    {
                        Id = pokemonDetails!.id,
                        Name = pokemonDetails!.name,
                        Base_Experience = pokemonDetails!.base_experience,
                        Height = pokemonDetails!.height,
                        Weight = pokemonDetails!.weight,

                        Sprites = new()
                        {
                            Front_Default = pokemonDetails.sprites.front_default,
                            Front_Shiny = pokemonDetails.sprites.front_shiny
                        },

                        Types = new(),
                        Stats = new(),
                        Moves = new()
                    };

                    pokemonDetails.types.ForEach(counter =>
                    {
                        Models.Type newType = new()
                        {
                            Name = counter.type.name
                        };

                        pokemon.Types.Add(newType);
                    });
                    pokemonDetails.stats?.ForEach(counter =>
                    {
                        Statistics newStats = new()
                        {
                            Name = counter.stat.name,
                            Base_Stat = counter.base_stat
                        };

                        pokemon.Stats.Add(newStats);
                    });
                    pokemonDetails.moves?.ForEach(counter =>
                    {
                        Models.Move newMove = new()
                        {
                            Name = counter.move.name
                        };

                        pokemon.Moves.Add(newMove);
                    });

                    pokemons.Add(pokemon);
                }

                SaveJson(pokemons, "");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void SaveJson<T>(List<T> jsonList, string path)
        {
            string json = JsonConvert.SerializeObject(jsonList.ToList());
            File.WriteAllText(path, json);

        }
    }
}
