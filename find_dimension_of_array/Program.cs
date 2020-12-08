using System;

namespace find_dimension_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] OneD = new int[10];
            int[,] TwoD = new int[3, 3];
            int[,,] ThreeD = new int[2, 3, 3];
            int[,,,] FourD = new int[2, 5, 6, 7];

            Console.WriteLine("Dimensions of OneD array is   : " + OneD.Rank);
            Console.WriteLine("Demensions of TwoD array is   : " + TwoD.Rank);
            Console.WriteLine("Demensions of ThreeD array is : " + ThreeD.Rank);
        }

    }
}

