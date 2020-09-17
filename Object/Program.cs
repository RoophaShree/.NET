using System;
using System.ComponentModel.DataAnnotations;

namespace Object
{
    class Program
    {
        class Carr
        {
            string color;
            int speed;


            static void Main(string[] args)
            {
                Carr myObj = new Carr();
                myObj.color = "Green";
                myObj.speed = 100;
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.speed);
            }

        }
    }
}
