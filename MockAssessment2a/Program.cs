using System;
using System.Collections.Generic;

namespace MockAssessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #1
            string[] characters = { "Obi-Wan", "Anikan", "Yoda", "Palpatine", "Luke" };
            Console.WriteLine($"Yoda is found in index {Challenge.AddStarWarsCharacters(characters)}");
            Console.WriteLine("");
            #endregion

            #region #2
            Dictionary<string, int> characterStats = new Dictionary<string, int>();
            characterStats.Add("Obi-Wan", 20);
            characterStats.Add("Anikan", 30);
            characterStats.Add("Yoda", 25);
            characterStats.Add("Palpatine", 23);
            characterStats.Add("Luke", 35);
            Console.WriteLine($"The character with the highest attack power is {Challenge.DeathStarCombat(characterStats)}");
            Console.WriteLine("");
            #endregion

            #region #3
            string[] planets = { "Mercury", "Earth", "Venus", "Jupitar", "Mars", "Neptune", "Saturn", "Uranus" };
            var listPlanets = Challenge.ConvertPlanets(planets);
            foreach(var planet in listPlanets)
            {
                Console.Write($"{planet}, ");
            }
            Console.WriteLine("\n\n");
            #endregion

            #region #4
            List<int> droids = new List<int>() { 4, 7, 2, 9, 10, 22, 53, 17, 94 , 63};
            Console.WriteLine($"The average for the even numbered droid is {Challenge.AverageDroids(droids)}");
            Console.WriteLine("");
            #endregion

            Console.WriteLine($"Successful Parse: {Challenge.TryToCatchDarthVadar("1")}");
            Console.WriteLine($"Unsuccessful Parse: {Challenge.TryToCatchDarthVadar("hello")}");

        }
    }
}
