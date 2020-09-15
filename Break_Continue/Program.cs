using System;
using System.Globalization;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int j=0;
            for(int i =0;i<20;i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            while(j<10)
                {
                Console.WriteLine(j);
                j++;
                if(j==5)
                { 
                    break;
                }
                  }
        }
    }
}
