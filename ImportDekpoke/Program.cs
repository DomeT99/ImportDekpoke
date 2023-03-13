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
                    case 1:
                        Request.GetPokemon(userInput.FolderPath!);
                        break;
                    case 2:
                        Console.WriteLine(2);
                        break;
                    case 3:
                        Console.WriteLine(3);
                        break;
                    case 4:
                        return;
                }
            } while (userInput.Value != 4);

        }


    }
}