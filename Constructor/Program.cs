using System;

namespace Constructor
{
    class Car
    {
        public string model;
        public string color;
        public int speed;
        
        public Car(string modelName, string modelColor, int modelSpeed)
        {
            model = modelName;
            color = modelColor;
            speed = modelSpeed;
           
     
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang","red",100);
            Console.WriteLine(Ford.model+ " " +Ford.color+ " " +Ford.speed);
            
        }
    }
}
