using System;

namespace Anonymous
{
    class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }
}
