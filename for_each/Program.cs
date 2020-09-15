using System;

namespace for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,5,7,9,10 };
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
