using System;

namespace Constructor
{
    class Car
    {
        public string color;

        public Car()
        {
            color = "red";
        }


        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.color);
        }
    }
}
