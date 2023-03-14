namespace ImportDekpoke.Utils
{
    internal class Menu
    {
        public static string[] _voices = { "1. Import Pokemon", "2. Import Moves", "3. Import Items", "4. Exit" };

        public static Option Choose()
        {
            Display();

            Option option = new();

            Console.WriteLine("Choose an option ");
            option.Value = (Choise)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify path to save json ");
            option.FolderPath = Console.ReadLine();


            Console.WriteLine();

            return option;
        }

        private static void Display()
        {
            Console.Clear();

            Styling();
            Console.WriteLine();
            Console.WriteLine("Choose an option");
            Console.WriteLine();

            for (int i = 0; i < _voices.Length; i++)
            {
                Console.WriteLine(_voices[i]);
            }

            Console.WriteLine();
        }

        private static void Styling()
        {

            Console.Title = "Import Dekpoke";
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
    public class Option
    {
        public Choise Value { get; set; }
        public string? FolderPath { get; set; }
    }
    public enum Choise
    {
        POKEMON = 1,
        MOVES = 2,
        ITEMS = 3,
        EXIT = 4
    }
}
