using System;

namespace Enum_Switch
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
            Level myLevel = Level.High;
            switch(myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;

                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;

                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }
        }
    }
}
