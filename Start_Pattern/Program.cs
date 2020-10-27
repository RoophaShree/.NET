using System;

namespace Start_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int row = 5; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
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