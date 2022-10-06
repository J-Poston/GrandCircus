namespace Unit2BasicLoopsLab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool unlocked = BreakinAttempt();

            if(unlocked == true)
            {
                Console.WriteLine("You did it! You broke the safe!");
            }

            else
            {
                Console.WriteLine("You've reached the limit for incorrect attempts.");
            }

            Console.WriteLine("Exiting program.");
            Environment.Exit(0);
        }

        static bool BreakinAttempt()
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
                        break;
                    }
                }
            } while (unlocked != true);

            return unlocked;
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