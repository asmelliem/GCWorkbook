using System;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            var proceed = "";
            do
            {
                Console.WriteLine("Please enter an integer: ");
                var userInput = Console.ReadLine();
                var validInput = int.TryParse(userInput, out var number);

                if (!validInput)
                {
                    Console.WriteLine("Whoops, looks like you typed in something that we can't process");
                    Console.WriteLine("");
                    proceed = "Y";
                    continue;
                }

                /*
                 * Table format idea came from Microsoft documentation. 
                 * Refer to https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting?redirectedfrom=MSDN
                 */

                Console.WriteLine("");
                Console.WriteLine("{0,-9} {1,-9} {2,-9}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-9} {1,-9} {2,-9}", "======", "=======", "=====");

                for (int currNum = 1; currNum <= number; currNum++)
                {
                    var square = currNum * currNum;
                    var cubed = currNum * currNum * currNum;
                    Console.WriteLine("{0,-9} {1,-9} {2,-9}", currNum, square, cubed);
                }

                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n)");
                proceed = Console.ReadLine().ToUpper();
                Console.WriteLine("");

            } while (proceed == "Y");

            
        }
    }
}
