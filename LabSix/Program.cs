using System;
using System.Text;

namespace LabSix
{
    public class Program
    {
        private static Random rand = new Random();

        public static void Main(string[] args)
        {
            var proceed = "";
            do
            {
                Console.WriteLine("Enter the number of sides for a pair of dice: ");
                var input = Console.ReadLine();
                var isValidInput = int.TryParse(input, out var numSides);               

                if (!isValidInput)
                {
                    Console.WriteLine("You did not put in a valid input. Please try again");
                    proceed = "Y";
                    continue;

                }

                var dieRoll = RollDice(numSides);
                var message = DiceRollMessages(dieRoll);

                Console.WriteLine("\nDice Roll: ");
                Console.WriteLine(message);

                Console.WriteLine("Roll again? (Y/N)");

            } while (proceed == "Y" || Console.ReadLine().ToUpper() == "Y");            
        }

        public static int [] RollDice(int numSides)
        {         

            var dieRoll = new int[2];

            for (int i = 0; i <= dieRoll.Length-1; i++) 
            {
                dieRoll[i] = rand.Next(1, numSides+1);
            }
            return dieRoll;            
        }

        public static string DiceRollMessages(int [] dieRoll)
        {
            StringBuilder message = new StringBuilder("");

            foreach(int die in dieRoll)
            {
                message.Append($"{die}\n");
            }

            if (dieRoll[0] == 1 && dieRoll[1] == 1)
            {
                message.Append("You rolled snake eyes!");
                return message.ToString();
            }
            else if(dieRoll[0] == 6 && dieRoll[1] == 6)
            {
                message.Append("You rolled box cars!");
                return message.ToString();
            }
            else if (dieRoll[0] + dieRoll[1] == 2 || dieRoll[0] + dieRoll[1] == 3 || dieRoll[0] + dieRoll[1] == 12)
            {
                message.Append("You rolled craps!");
                return message.ToString();
            }
            else
            {
                return message.ToString();
            }
        }
    }
}
