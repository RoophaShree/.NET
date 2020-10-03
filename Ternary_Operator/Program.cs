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

            int r = 10, p = 100;

            string result1 = r > p ? "r is greater than p"
                                    : r < p ? "r is less than p"
                                        : r == p ? "r is equal to p" : "No result";

            Console.WriteLine(result1);


            int c = 5, d = 10, z = 15;

            int result2 = c * 3 > d ? c : d > z ? d : z;

            Console.WriteLine(result2);
        }
    }
}
