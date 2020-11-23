﻿using System;

namespace Nested_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            
            Console.Write("Enter a number (1-3): ");
            number = Convert.ToInt32(Console.ReadLine());

            
            switch (number)
            {
                case 1:
               
                    char color;
                    Console.Write("Enter color value (R/G/B): ");
                    color = Console.ReadLine()[0];
                  
                    switch (color)
                    {
                        case 'R':
                        case 'r':
                            Console.WriteLine("You've choesn \"Red\" color");
                            break;
                        case 'G':
                        case 'g':
                            Console.WriteLine("You've choesn \"Green\" color");
                            break;
                        case 'B':
                        case 'b':
                            Console.WriteLine("You've choesn \"Blue\" color");
                            break;
                        default:
                            Console.WriteLine("Invalid color code");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Input is 2");
                    break;

                case 3:
                    Console.WriteLine("Input is 3");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            //Console.ReadLine();
        }
    }
}
