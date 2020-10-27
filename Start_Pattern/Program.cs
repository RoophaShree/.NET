/*using System;

namespace starpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
*/

using System;

namespace Start_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 5; i >= 1; i--) 
            {
                for (j = 1; j <= i; j++) 
                {
                    Console.WriteLine("*");
                }
                 Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}


/*using System.IO;
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


using System.IO;
using System;

/*class Program
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
*/