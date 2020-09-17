using System;

namespace Object_Method
{
    class Car
    {
        string color="red";
        string model = "2019";
        public void carSpeed()
        {
            Console.WriteLine("The car is going in its highest speed");
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            myObj.carSpeed();
        }
    }
}
