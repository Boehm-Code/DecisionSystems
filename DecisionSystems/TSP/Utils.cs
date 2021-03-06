using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionSystems.TSP
{
    public static class Utils
    {
        public static double GetDistance(Location l1, Location l2)
        {
            var dx = l2.X - l1.X;
            var dy = l2.Y - l1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double GetDistance(IReadOnlyCollection<int> solution, IReadOnlyList<Location> cities)
        {
            return solution
                .Concat(new[] { solution.First() })
                .Select(index => cities[index - 1])
                .Pairwise(GetDistance)
                .Sum();
        }
    }
}