using System;

namespace Ternary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 30;

            var result = x > y ? "x is greater than y" : "x is less than or equal to y";

            Console.WriteLine(result);

            int a = 20, b = 10;

            if (x > y)
                Console.WriteLine("a is greater than b");
            else
                Console.WriteLine("a is less than b");
        }
    }
}
