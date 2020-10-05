using System;

namespace Largest_number
{
    class Program
    {
        static int[] arr = { 10, 324, 45, 90, 9808, 234568,1,123456789 };
        static int largest()
        {
            int i;
            int max = arr[0];
            for (i = 1; i < arr.Length; i++)

                if (arr[i] > max)
                    max = arr[i];

            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Largest in given array is " + largest());

        }
    }
}
