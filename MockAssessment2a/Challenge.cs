using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockAssessment2a
{
    public class Challenge
    {
        public static int AddStarWarsCharacters(string [] characters)
        {
            int index = Array.FindIndex(characters, w => w.Contains("Yoda"));
            return index;
        }

        public static string DeathStarCombat(Dictionary<string,int> characterStats)
        {
            string character = characterStats.OrderByDescending(x => x.Value).First().Key;
            return character;
        }

        public static List<string> ConvertPlanets(string [] planets)
        {
            List<string> reversedPlanets = new List<string>();
            for (int i = planets.Length-1; i >= 0; i--)
            {
                reversedPlanets.Add(planets[i]);
            }
            return reversedPlanets;
        }

        public static double AverageDroids(List<int> droids)
        {
            List<int> evenNumberedDroids = new List<int>();
            foreach (var droid in droids)
            {
                if(droid%2 == 0)
                {
                    evenNumberedDroids.Add(droid);
                }
            }

            double sum = 0;
            foreach (var evenDroid in evenNumberedDroids)
            {
                sum += evenDroid;
            }

            return sum / evenNumberedDroids.Count();
        }

        public static string TryToCatchDarthVadar(string sentence)
        {
            try
            {
                int.Parse(sentence);
                return "Vadar Was Captured!";

            }
            catch(FormatException)
            {
                return "Vadar Got Away!";
            }
        }
    }
}
