using System;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<20;i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
