using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionSystems.TSP
{
    public static class Utils
    {
        public static double GetDistance(IReadOnlyCollection<int> solution, IReadOnlyList<Location> cities)
        {

            var lastCity = solution.Last();
            var distance = 0.0;

            foreach (var position in solution)
            {
                var previousCity = cities[lastCity - 1];
                var city = cities[position - 1];

                distance += GetDistance(previousCity, city);
                lastCity = position;
            }

            return distance;
        }

        private static double GetDistance(Location location1, Location location2)
        {
            return Math.Sqrt(Math.Pow(location2.X - location1.X, 2) + Math.Pow(location2.Y-location1.Y,2));
        }
        
    }
}