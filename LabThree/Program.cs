using System;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();

            var cont = "";
            do
            {
                Console.WriteLine("Enter a whole number between 1 and 100");
                var numberInput = Console.ReadLine();

                var validNumber = int.TryParse(numberInput, out var number);

                if (!validNumber || (number > 99 || number < 2))
                {
                    Console.WriteLine("You didn't enter a valid number");
                    Console.WriteLine("");
                    continue;
                }

                string numType;
                if (number % 2 == 0)
                {
                    numType = "Even";
                }
                else
                {
                    numType = "Odd";
                }

                Console.WriteLine("");
                Console.WriteLine($"Hello {name}");

                if (numType == "Even" && (number >= 2 && number < 25))
                {
                    Console.WriteLine("This number is even and less than 25.");
                }
                else if(numType == "Even" && (number >= 26 && number <= 60))
                {
                    Console.WriteLine("This number is even.");
                }
                else if (numType == "Even" && number >60)
                {
                    Console.WriteLine($"{number} is Even");
                }
                else if (numType == "Even" && number > 60)
                {
                    Console.WriteLine($"{number} is Even");
                }
                else if (numType == "Odd" && number > 60)
                {
                    Console.WriteLine($"{number} is Odd");
                }
                else if (numType == "Odd")
                {
                    Console.WriteLine($"{number} is Odd");
                }
                else
                {
                    Console.WriteLine($"{number} is Even");
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                cont = Console.ReadLine().ToUpper();

            } while (cont == "Y");
        }
    }
}
