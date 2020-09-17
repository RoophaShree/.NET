using System;
using System.Drawing;

namespace Class
{
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car myobj1 = new Car();
            Car myobj2 = new Car();
            Console.WriteLine(myobj1.color);
            Console.WriteLine(myobj2.color);
        }
        
    }
}
