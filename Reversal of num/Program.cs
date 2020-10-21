using System;

namespace Reversal_of_num
{
    class Program
    {
        static void Main(string[] args)
        {
			
			
				double a = 4590828913456789013, rev = 0, b;

				
				while (a != 0)
				{
					b = a % 10;        
					rev = (rev * 10) + b;   
					a = a / 10;             
				}
				Console.WriteLine("The reverse of the number is: " + rev);
			}
		}
	}
