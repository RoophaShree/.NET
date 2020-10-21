using System;

namespace Reversal_of_num
{
    class Program
    {
        static void Main(string[] args)
        {
			
			
				int a = 721, rev = 0, b;

				
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
