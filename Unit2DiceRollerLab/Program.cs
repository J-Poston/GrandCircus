namespace Unit2DiceRollerLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sides are on your dice?");

            int diceSides = 0;
            bool validInt = false;

            // get sides of dice
            while(validInt == false)
            {
                validInt = int.TryParse(Console.ReadLine(), out diceSides);
                if(validInt == false) { Console.WriteLine("Please enter a valid number."); }
            }

            bool rollAgain = true;

            // role dice
            while(rollAgain == true)
            {
                int[] diceValues = RollDice(diceSides);
                //int[] diceValues = new int[2] { 6, 6 };

                string combo;

                if(diceSides == 6)
                {
                    combo = Get6SidedDiceCombo(diceValues[0], diceValues[1]);
                    Console.WriteLine(combo);
                    if(diceValues.Sum() == 12) { Console.WriteLine("Craps"); }
                    // added extra WriteLine() for possible value of 12
                    // Get6SidedDiceCombo() is only allowed to return one string per requirements
                }

                else
                {
                    combo = GetDiceCombo(diceValues[0], diceValues[1]);
                    Console.WriteLine(combo);
                }
                // ask again
                rollAgain = AskToRollAgain();                
            }

        }
        static int[] RollDice(int diceSides)
        {
            Console.WriteLine("Roll the dice. (Press Enter)");
            Console.ReadLine();
            Random dice = new Random();

            int[] diceValues = new int[2];
            diceValues[0] = dice.Next(1,diceSides);
            diceValues[1] = dice.Next(1,diceSides);

            Console.WriteLine($"Dice1: {diceValues[0]}");
            Console.WriteLine($"Dice2: {diceValues[1]}");
            Console.WriteLine($"Total: {diceValues.Sum()}");

            return diceValues;
        }

        static string Get6SidedDiceCombo(int dice1, int dice2)
        {
            string combo = "";
            int sum = dice1 + dice2;
            if (dice1 == 1 && dice2 == 1) { combo = "Snake eyes!"; }
            if (dice1 == 1 && dice2 == 2) { combo = "Ace Deuce"; }
            if (dice1 == 2 && dice2 == 1) { combo = "Ace Deuce"; }
            if (dice1 == 6 && dice2 == 6) { combo = "Box Cars"; }
            if (sum == 7 || sum == 11) { combo = "Win"; }
            if (sum == 2 || sum == 3 /*|| sum == 12*/) { combo = "Craps"; }
            return combo;
        }

        static string GetDiceCombo(int dice1, int dice2)
        {
            string combo = "";
            int sum = dice1 + dice2;
            if (dice1 == 1 && dice2 == 5) { combo = "Boom!"; }
            if (dice1 == 5 && dice2 == 1) { combo = "Boom!"; }
            if (dice1 == 1 && dice2 == 4) { combo = "Winner Winner!"; }
            if (dice1 == 4 && dice2 == 1) { combo = "Winner Winner!"; }
            if (dice1 == 6 && dice2 == 3) { combo = "Ohhh... unlucky."; }
            if (dice1 == 3 && dice2 == 6) { combo = "Ohhh... unlucky."; }
            return combo;
        }

        static bool AskToRollAgain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Roll again?");
            Console.ForegroundColor = ConsoleColor.Gray;

            bool rollAgain = false;
            bool validBool = false;
            while(validBool == false)
            {
                validBool = bool.TryParse(Console.ReadLine(), out rollAgain);
                if (validBool == false) { Console.WriteLine("Please enter 'true' or 'false'"); }
            }
            return rollAgain;
        }
    }
}