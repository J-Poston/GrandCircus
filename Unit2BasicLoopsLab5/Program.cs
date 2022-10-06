namespace Unit2BasicLoopsLab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combination;
            bool unlocked = false;
            int numAttempts = 0;
            do
            {

                combination = GetCombination();
                unlocked = VerifyCombination(combination);

                if (unlocked == false)
                {
                    numAttempts++;

                    if (numAttempts == 5)
                    {
                        Console.WriteLine("You've reached the limit for incorrect attempts.");
                        Console.WriteLine("Exiting program.");
                        Environment.Exit(0);
                    }
                }
            } while (unlocked != true);

            Console.WriteLine("You did it! You broke the safe!");
        }

        static int GetCombination()
        {
            int combination = 0;

            Console.Write("Enter the combination. (Hint: it's 13579):");
            int.TryParse(Console.ReadLine(), out combination);

            return combination;
        }

        static bool VerifyCombination(int combination)
        {
            bool unlocked;

            if (combination == 13579)
            {
                unlocked = true;
            }
            else
                unlocked = false;

            return unlocked;
        }
    }
}