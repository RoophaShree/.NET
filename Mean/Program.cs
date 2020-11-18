using System;
using System.Collections.Generic;

namespace Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double> { 11, 22, 33, 44, 55,87};

            double mean = 0;
            double sum = 0;

            int i = 0;

            for (i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            mean = sum / (list.Count - 0);

            Console.WriteLine("Mean: " + mean);
        }
    }
    }

