using System;

namespace Anonymous
{
    class Program
    {
        public delegate void Print(int value);
        public static void Main(string[] args)
        {
            int i = 10;
            Print print = delegate (int val) {
                val += i;
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }
}
