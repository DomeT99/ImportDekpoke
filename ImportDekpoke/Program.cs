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
                        Request.GetData(userInput.FolderPath!, "/pokemon/?limit=151", Choise.POKEMON);
                        break;
                    case Choise.MOVES:
                        Request.GetData(userInput.FolderPath!, "/move/?limit=50", Choise.MOVES);
                        break;
                    case Choise.ITEMS:
                        Request.GetData(userInput.FolderPath!, "/item/?limit=50", Choise.ITEMS);
                        break;
                    case Choise.EXIT:
                        return;
                }
            } while (userInput.Value != Choise.EXIT);

        }


    }
}