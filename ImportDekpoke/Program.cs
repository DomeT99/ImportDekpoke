using ImportDekpoke.HttpRequest;
using ImportDekpoke.Utils;

namespace ImportDekpoke
{
    internal class Program
    {
        static void Main()
        {

            int userInput = 0;

            do
            {
                userInput = Menu.Choose();

                switch (userInput)
                {
                    case 1:
                        Request.GetPokemon();
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
            } while (userInput != 4);
        }


    }
}