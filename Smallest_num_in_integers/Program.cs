using System;

namespace Smallest_num_in_integers
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int small = 0;
            int[] a = new int[5];

            Console.WriteLine("Enter the array elements: ");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                //Console.WriteLine("The Elements are :\n");
                a[i] = int.Parse(Console.ReadLine());
            }
            small = a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (small > a[i])
                small = a[i];
            }
            Console.WriteLine("The smallest element among the array elements are:" + small);
        }
    }
}
