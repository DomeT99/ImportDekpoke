using ImportDekpoke.HttpRequest;
using ImportDekpoke.Utils;

namespace ImportDekpoke
{
    internal class Program
    {
        static void Main()
        {

            Option userInput = new();

            do
            {
                userInput = Menu.Choose();

                switch (userInput.Value)
                {
                    case Choise.POKEMON:
                        Request.GetPokemon(userInput.FolderPath!);
                        break;
                    case Choise.MOVES:
                        Request.GetMoves(userInput.FolderPath!);
                        break;
                    case Choise.ITEMS:
                        Console.WriteLine(3);
                        break;
                    case Choise.EXIT:
                        return;
                }
            } while (userInput.Value != Choise.EXIT);

        }


    }
}