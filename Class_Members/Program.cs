using System;

namespace Class_Members
{
    class Program
    {
        class Car
        {
            string model;
            string color;
            int year;

            static void Main(string[] args)
            {
                Car Civic = new Car();
                Civic.model = "Honda";
                Civic.color = "white";
                Civic.year = 2003;

                Car Ford = new Car();
                Ford.model = "Mustang";
                Ford.color = "Yellow";
                Ford.year = 2014;

                Console.WriteLine(Civic.model);
                Console.WriteLine(Ford.color);

            }
        }
    }
}
