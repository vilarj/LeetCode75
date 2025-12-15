using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Problem_4
{
    public class CanPlaceFlower
    {
        public CanPlaceFlower(int[] flowerbed, int n)
        {
            Console.WriteLine("Flowerbed: [" + string.Join(", ", flowerbed) + "]");
            Console.WriteLine("Number of flowers to place: " + n);
            Console.WriteLine("Can place flowers: " + CanPlaceFlowers(flowerbed, n));
        }

        private static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int bedLength = flowerbed.Length;

            for (int i = 0; i < bedLength; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool leftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                    bool rightEmpty = (i == bedLength - 1) || (flowerbed[i + 1] == 0);

                    if (leftEmpty && rightEmpty)
                    {
                        flowerbed[i] = 1;
                        n--;

                        if (n == 0)
                        {
                            return true;
                        }
                    }
                }
            }

            return n <= 0;
        }
    }
}