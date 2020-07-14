using System;

namespace LabThree
{
    public class Program
    {
        public static void Main(string[] args)
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

                var numType = DetermineEvenOdd(number);                             

                if (numType == "Even")
                {
                    var output = DetermineEvenOutput(number, name);
                    Console.WriteLine(output);
                }
                else
                {
                    var output = DetermineOddOutput(number, name);
                    Console.WriteLine(output);
                }                

                Console.WriteLine("Would you like to continue? (y/n)");
                cont = Console.ReadLine().ToUpper();

            } while (cont == "Y");
        }

        public static string DetermineEvenOdd(int value)
        {
            string numType;
            if (value % 2 == 0)
            {
                numType = "Even";
            }
            else
            {
                numType = "Odd";
            }
            return numType;
        }

        public static string DetermineEvenOutput(int value, string name)
        {
            if (value >= 2 && value < 25)
            {
                return $"\n\nHello {name}\nThis number is even and less than 25.";
            }
            else if (value >= 26 && value <= 60)
            {
                return $"\n\nHello {name}\nThis number is even.";
            }
            else
            {
                return $"\n\nHello {name}\n{value} is even";
            }
        }

        public static string DetermineOddOutput(int value, string name) 
        {
            if (value > 60)
            {
                return $"\n\nHello {name}\n{value} is odd and greater than 60";
            }
            else  
            {
                return $"\n\nHello {name}\n{value} is odd";
            }
        }
    }
}
