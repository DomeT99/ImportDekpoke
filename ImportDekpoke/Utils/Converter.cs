﻿using ImportDekpoke.Models;
using ImportDekpoke.Models.APIModels;
using Newtonsoft.Json;
using RestSharp;

namespace ImportDekpoke.Utils
{
    class Converter
    {

        public static void ToJson(List<Result> json, string folderPath, Choise choise)
        {
            switch (choise)
            {
                case Choise.POKEMON:
                    Pokemon(json, folderPath);
                    break;
                case Choise.MOVES:
                    Moves(json, folderPath);
                    break;
                case Choise.ITEMS:
                    Items(json, folderPath);
                    break;
                case Choise.EXIT:
                    return;
            }
        }

        private async static void Pokemon(List<Result> jsonPokeApi, string folderPath)
        {
            List<Pokemon> pokemons = new();
            RestResponse response = new();


            try
            {

                foreach (Result? counterPokeApi in jsonPokeApi)
                {

                    response = await Call.Get(counterPokeApi.Url!);

                    PokemonDetails? pokemonDetails = JsonConvert.DeserializeObject<PokemonDetails>(response.Content!, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });


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

                Utility.SaveJson(pokemons, folderPath, "pokemon");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async static void Moves(List<Result> jsonMoveApi, string folderPath)
        {
            List<Models.Move> moves = new();
            RestResponse response = new();

            try
            {

                foreach (Result? counterMoveApi in jsonMoveApi)
                {

                    response = await Call.Get(counterMoveApi.Url!);


                    MoveDetails? moveDetails = JsonConvert.DeserializeObject<MoveDetails>(response.Content!, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });


                    TypeMove moveType = new()
                    {
                        name = moveDetails!.type.name
                    };

                    Models.Move newMove = new()
                    {
                        Name = moveDetails!.name,
                        Power = moveDetails!.power,
                        Accuracy = moveDetails!.accuracy,
                        Type = moveType.name,
                    };

                    moves.Add(newMove);

                }

                Utility.SaveJson(moves, folderPath, "moves");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async static void Items(List<Result> jsonItemApi, string folderPath)
        {
            List<Models.Item> items = new();
            RestResponse response = new();

            try
            {

                foreach (Result? counterItemApi in jsonItemApi)
                {

                    response = await Call.Get(counterItemApi.Url!);

                    ItemDetails? itemDetails = JsonConvert.DeserializeObject<ItemDetails>(response.Content!, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    Models.Item newItem = new()
                    {
                        Name = itemDetails!.name,
                        Cost = itemDetails!.cost,
                        Effect = itemDetails!.effect_entries[0].short_effect,
                        Sprite = itemDetails!.sprites.Default
                    };
                    items.Add(newItem);
                }

                Utility.SaveJson(items, folderPath, "items");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
