using System;

namespace Array_reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 6, 8, 9, 0, 2, 3 };
            foreach(int a in array)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array is:");
            foreach(int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
