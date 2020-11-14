using System;

namespace Eample
{
    class Program
    {
        public static int GetMagnitude(int num)
        {
            int magnitude = 0;

            while (num > 0)
            {
                magnitude++;
                num = num / 10;
            }
            return magnitude;
        }
        public static void Main()
        {
            int num = 34521;
            int mag = 0;

            mag = GetMagnitude(num);

            Console.WriteLine("Magnitude: " + mag);
        }
    }
    }

