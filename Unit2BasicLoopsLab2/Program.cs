namespace Unit2BasicLoopsLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";
            int number;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter a number:");

                int.TryParse(Console.ReadLine(), out number);

                for(int i = number; i >= 0; i--)
                {
                    Console.Write($"{i} ");
                }
                
                Console.WriteLine();

                for (int i = 0; i <= number; i++)
                {
                    Console.Write($"{i} ");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Would you like to continue? (y/n)");

                repeat = Console.ReadLine();

            } while (repeat.ToLower() == "y");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Goodbye!");
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
    }
}