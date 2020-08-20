using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets_and_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
           var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            Console.WriteLine($"{string.Join(",", planetList)}");
            var lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            Console.WriteLine($"{string.Join(",", planetList)}");

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            Console.WriteLine($"{string.Join(",", planetList)}");

            planetList.Add("Pluto");

            Console.WriteLine($"{string.Join(",", planetList)}");

            var rockyPlanets = new List<string>(planetList.GetRange(0, 3));

            Console.WriteLine($"Rocky Planets: {string.Join(",", rockyPlanets)}");

            planetList.Remove("Pluto");

            Console.WriteLine($"Removed Pluto: {string.Join(",", planetList)}");

            var Spaceship = new Dictionary<string, List<string>>
            {
                {
                    "Voyager 1", new List<string> {"Mercury", "Jupiter", "Mars"}
                },
                {
                    "Voyager 2", new List<string> {"Mercury", "Earth", "Mars"}
                },
                {
                    "Mariner 3", new List<string> {"Saturn", "Jupiter", "Uranus"}               
                },
                {
                    "Mariner 10", new List<string> {"Neptune", "Venus", "Pluto"}
                }
            };

            foreach (var planet in planetList)
            {
                var probes = Spaceship.Where(probe => probe.Value.Contains(planet)).Select(probe => probe.Key);
                Console.WriteLine($"{planet}: {string.Join("," , probes)}");
            }

        }
    }
}
