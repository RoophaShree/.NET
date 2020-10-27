/*using System;

namespace Start_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //int row = 0;
            //int col = 0;

            for (int row = 4; row >= 1; --row)
            {
                for (int col = 1; col >= 1; ++col)
                {
                    Console.WriteLine("*");
                }

                Console.WriteLine();
            }
        }
    }
}


using System.IO;
using System;
class Program
{
    static void Main()
    {
        for (int i = 6; i >= 1; --i)
        {
            for (int j = 1; j >= i; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
*/

using System.IO;
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}