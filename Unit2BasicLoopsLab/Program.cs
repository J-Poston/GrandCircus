namespace Unit2BasicLoopsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat = "y";

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Hello, World!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Would you like to continue? (y/n)");
                repeat = Console.ReadLine();

            } while (repeat.ToLower() == "y");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Goodbye!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}