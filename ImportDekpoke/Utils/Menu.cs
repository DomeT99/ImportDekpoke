namespace ImportDekpoke.Utils
{
    internal class Menu
    {
        public static string[] _voices = { "1. Import Pokemon", "2. Import Moves", "3. Import Items", "4. Exit" };

        public static int Choose()
        {
            Display();

            var result = Console.ReadLine();
            Console.WriteLine();

            return Convert.ToInt32(result);
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

}
