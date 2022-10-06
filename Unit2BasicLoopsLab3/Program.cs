namespace Unit2BasicLoopsLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combination;
            bool unlocked = false;

            while (unlocked != true)
            {
                
                combination = GetCombination();
                unlocked = VerifyCombination(combination);
            }

            Console.WriteLine("You did it! You broke the safe!");
            Console.WriteLine("Good thing, too... because you couldn't escape this program if you didn't!");
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