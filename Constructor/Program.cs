using System;

namespace Constructor
{
    class Car
    {
        public string color;
        public int speed;

        public Car()
        {
            color = "White";
            speed = 100;
        }


        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.speed);
        }
    }
}
