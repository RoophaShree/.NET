using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = 22;
            if (time1 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time1 < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
        }
    }
}
