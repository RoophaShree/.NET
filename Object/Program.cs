using System;
using System.ComponentModel.DataAnnotations;

namespace Object
{
    class Program
    {
        class Carr
        {
            string color = "blue";
            int speed = 100;


            static void Main(string[] args)
            {
                Carr myObj = new Carr();
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.speed);
            }

        }
    }
}
