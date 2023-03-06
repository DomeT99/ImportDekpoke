namespace ImportDekpoke
{
    internal class Program
    {
        static void Main()
        {
            int userInput = 0;
           
            do
            {
                userInput = DisplayMenu();

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine(1);
                        break;
                    case 2:
                        Console.WriteLine(2);
                        break;
                    case 3:
                        Console.WriteLine(3);
                        break;
                    default:
                        Console.WriteLine("Choose a valid option");
                        Console.WriteLine();
                        break;
                }
            } while (userInput != 4);
        }

        private static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option");
            Console.WriteLine();
            Console.WriteLine("1. Import Pokemon");
            Console.WriteLine("2. Import Moves");
            Console.WriteLine("3. Import Items");
            Console.WriteLine("4. Exit");

            var result = Console.ReadLine();
            Console.WriteLine();
            return Convert.ToInt32(result);
        }
    }
}