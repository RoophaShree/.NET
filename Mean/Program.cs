using System;
using System.Collections.Generic;

namespace Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double> { 11, 22, 33, 44, 55 };

            double mean = 0;
            double sum = 0;

            int loop = 0;

            for (loop = 0; loop < list.Count; loop++)
            {
                sum += list[loop];
            }

            mean = sum / (list.Count - 0);

            Console.WriteLine("Mean: " + mean);
        }
    }
    }

