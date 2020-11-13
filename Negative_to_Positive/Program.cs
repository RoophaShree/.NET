using System;

namespace Negative_to_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -10, -20, 30, -40, 50, -60, 70, -90};
            int loop = 0;

            for (loop = 0; loop < arr.Length; loop++)
            {
                if (arr[loop] < 0)
                    arr[loop] = -arr[loop];
            }

            Console.WriteLine("Array elements after conversion:");
            for (loop = 0; loop < arr.Length; loop++)
            {
                Console.Write(arr[loop] + " ");
            }
            Console.WriteLine();
        }
    }
}
