using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
			int a = 567, sum = 0, b;

			
			while (a != 0)
			{
				b = a % 10;      
				sum = sum + b;   
				a = a / 10;      
			}
			Console.WriteLine("The sum of the digits is: " + sum);
		}
	}
}
    

