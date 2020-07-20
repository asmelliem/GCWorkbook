using System;

namespace LabSix
{
    public class Program
    {
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
                
                foreach(int die in dieRoll)
                {
                    Console.WriteLine(die);
                }

                Console.WriteLine("Roll again? (Y/N)");

            } while (proceed == "Y" || Console.ReadLine().ToUpper() == "Y");
            
        }

        public static int [] RollDice(int numSides)
        {
            var rand = new Random();

            var dieRoll = new int[2];

            for (int i = 0; i <= dieRoll.Length-1; i++) 
            {
                dieRoll[i] = rand.Next(1, numSides);
            }

            return dieRoll;


            
        }
    }
}
