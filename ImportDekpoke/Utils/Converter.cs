using ImportDekpoke.Models;
using ImportDekpoke.Models.APIModels;
using Newtonsoft.Json;
using RestSharp;

namespace ImportDekpoke.Utils
{
    class Converter
    {
        public static void ToJsonPokemon(List<Result> jsonPokeApi)
        {
            List<Pokemon> pokemons = new();
            RestResponse response = new();
            Pokemon pokemon = new();

            try
            {
                jsonPokeApi.ForEach(async (counterPokeApi) =>
                {
                    response = await Call.Get(counterPokeApi.Url!);

                    PokemonDetails? pokemonDetails = JsonConvert.DeserializeObject<PokemonDetails>(response.Content!);

                    pokemon.Id = pokemonDetails!.id;
                    pokemon.Name = pokemonDetails!.name;
                    pokemon.Base_Experience = pokemonDetails!.base_experience;
                    pokemon.Height = pokemonDetails!.height;
                    pokemon.Weight = pokemonDetails!.weight;

                    pokemon.Sprites = new()
                    {
                        Front_Default = pokemonDetails.sprites.front_default,
                        Front_Shiny = pokemonDetails.sprites.front_shiny
                    };

                    pokemonDetails.types.ForEach(counter =>
                    {
                        Models.Type newType = new()
                        {
                            Name = counter.type.name
                        };

                        pokemon.Types?.Add(newType);
                    });
                    pokemonDetails.stats?.ForEach(counter =>
                    {
                        Statistics newStats = new()
                        {
                            Name = counter.stat.name,
                            Base_Stat = counter.base_stat
                        };

                        pokemon.Stats?.Add(newStats);
                    });
                    pokemonDetails.moves?.ForEach(counter =>
                    {
                        Models.Move newMove = new()
                        {
                            Name = counter.move.name
                        };

                        pokemon.Moves?.Add(newMove);
                    });

                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
