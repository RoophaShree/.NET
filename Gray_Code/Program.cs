using System;

namespace Gray_Code
{
    class Program
    {
        public static int CreateGraycode(int num)
        {
            int gray = 0;

            gray = num ^ (num >> 1);

            return gray;
        }

        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Number \tGray Code");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(string.Format("{0}\t{1}", i, Convert.ToString((int)CreateGraycode(i), 2)));
            }
        }
    }
}
