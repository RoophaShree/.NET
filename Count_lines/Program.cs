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
            string str = "Mumbai Indians\nDelhi Capitals\nRajsthan Royals";

            int lines = 0;

            Console.WriteLine("Lines:");
            Console.WriteLine(str);
            lines = CountLines(str);
            Console.WriteLine("Total lines in a string: " + lines);
        }

    }
}