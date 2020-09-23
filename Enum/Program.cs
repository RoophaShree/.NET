using System;

namespace Enum
{
    

    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level myLevel = Level.Medium;

            Console.WriteLine(myLevel);
        }
    }
}
