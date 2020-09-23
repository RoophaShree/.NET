using System;

namespace Enum
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    class Program
    {
        static void Main(string[] args)
        {
            Level myLevel = Level.Medium;

            Console.WriteLine(myLevel);
        }
    }
}
