using System;

namespace Enum_values
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
    }
    class Program
    {
        static void Main(string[] args)
        {
            int myMonths = (int)Months.July;
            Console.WriteLine(myMonths);
        }
    }
}
