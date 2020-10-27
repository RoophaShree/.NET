using System;

namespace Next_Star_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;

            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

           /* int i, k,j;
            for (i = 5; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (k=5; k>=i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
*/
