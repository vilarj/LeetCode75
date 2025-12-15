using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Problem_3
{
    public class Candies
    {
        public Candies(int[] candies, int extraCandies) {
            Console.WriteLine("Candies: [" + string.Join(", ", candies) + "]");
            Console.WriteLine("Extra Candies: " + extraCandies);
            Console.WriteLine("Kids with greatest candies: [" + string.Join(", ", KidsWithGreatestCandies(candies, extraCandies)) + "]");
        }

        private static IList<bool> KidsWithGreatestCandies(int[] candies, int extraCandies)
        {
            int candiesLength = candies.Length, maxCandies = 0;
            var kidsGreatestCandies = new List<bool>(candiesLength);

            for (int i = 0; i < candiesLength; i++)
            {
                if (candies[i] > maxCandies)
                {
                    maxCandies = candies[i];
                }
            }

            for (int i = 0; i < candiesLength; i++)
            {
                int possible = candies[i] + extraCandies;

                if (possible >= maxCandies)
                {
                    kidsGreatestCandies.Add(true);
                }
                else
                {
                    kidsGreatestCandies.Add(false);
                }
            }

            return kidsGreatestCandies;
        }
    }
}
