using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
			int c = 15675, sum= 0, b;

			
			while (c!= 0)
			{
				b = c % 10;      
				sum = sum + b;   
				c = c / 10;      
			}

			Console.WriteLine("The sum of the digits is: "  + sum);
		}
	}
}
    

