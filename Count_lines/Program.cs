using System;

namespace Count_lines
{
    class Program
    {
        static int CountLines(string str)
        {
            int lines = 1;
            int index = 0;
            while (true)
            {
                index = str.IndexOf('\n', index);
                if (index < 0)
                    break;
                lines++;
                index++;
            }
            return lines;
        }
        static void Main()
        {
            string str = "I am RoophaShree\n I am pyrsuing my masters in UCM\n I will complete my masters in the month of May 2021";

            int lines = 0;

            Console.WriteLine("Lines:");
            Console.WriteLine(str);
            lines = CountLines(str);
            Console.WriteLine("Total lines in a string: " + lines);
        }

    }
}