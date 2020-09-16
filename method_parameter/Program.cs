using System;

namespace method_parameter
{
    class Program
    {
        static void myMethod(string fname)
        {
            Console.WriteLine("Ryon " + fname);

        }
        static void Main(string[] args)
        {
            myMethod("Robin");
            myMethod("Pascal");
            myMethod("Ghays");
            myNextMethod();
            myNextMethod("India");
            myNextMethod("Canada");
            myNextMethod("United Kingdoms");
            myMultipleParameter("Roopa", 26);
            myMultipleParameter("Shilpa", 27);
            int c = myReturnMethod(2, 3);
            Console.WriteLine(c);
            keyValueMethod(food4: "Biryani", food1: "Poori", food3: "Burger", food2: "Pizza");

        }
        static void myNextMethod(string country="The USA")
        {
            Console.WriteLine(country);
        }
        static void myMultipleParameter(string fname, int age)
        {
            Console.WriteLine(fname + " is "  + age , "years old");
        }
        static int myReturnMethod(int a, int b)
        {
            
            return b * a;
          
           
        }
        static void keyValueMethod(string food1,string food2,string food3,string food4)
        {
            Console.WriteLine("One of my Fav food is: " + food4);
        }
    }
}
