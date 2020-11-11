using System;

namespace Relational_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            //printing return type
            Console.WriteLine("Return type of == operator: {0}", (a == b).GetType());
            Console.WriteLine("Return type of != operator: {0}", (a != b).GetType());
            Console.WriteLine("Return type of > operator : {0}", (a > b).GetType());
            Console.WriteLine("Return type of >= operator: {0}", (a >= b).GetType());
            Console.WriteLine("Return type of < operator : {0}", (a < b).GetType());
            Console.WriteLine("Return type of <= operator: {0}", (a <= b).GetType());
            Console.WriteLine("a==b: {0}", (a == b));
            Console.WriteLine("a!=b: {0}", (a != b));
            Console.WriteLine("a>b : {0}", (a > b));
            Console.WriteLine("a>=b: {0}", (a >= b));
            Console.WriteLine("a<b : {0}", (a < b));
            Console.WriteLine("a<=b: {0}", (a <= b));

            //checking conditions
            if (a == b)
                Console.WriteLine("a is equal to b");
            else
                Console.WriteLine("a is not equal to b");
            if (a != b)
                Console.WriteLine("a is not equal to b");
            else
                Console.WriteLine("a is equal to b");
            if (a > b)
                Console.WriteLine("a is greater than b");
            else
                Console.WriteLine("a is not greater than b");
            if (a >= b)
                Console.WriteLine("a is greater than or equal to b");
            else
                Console.WriteLine("a is not greater than or equal to b");
            if (a < b)
                Console.WriteLine("a is less than b");
            else
                Console.WriteLine("a is not less than b");
            if (a <= b)
                Console.WriteLine("a is less than or equal to b");
            else
                Console.WriteLine("a is not less than or equal to b");

            //checking conditions in another way
            if ((a == b) == true)
                Console.WriteLine("a is equal to b");
            else
                Console.WriteLine("a is not equal to b");
            if ((a != b) == true)
                Console.WriteLine("a is not equal to b");
            else
                Console.WriteLine("a is equal to b");
            if ((a > b) == true)
                Console.WriteLine("a is greater than b");
            else
                Console.WriteLine("a is not greater than b");
            if ((a >= b) == true)
                Console.WriteLine("a is greater than or equal to b");
            else
                Console.WriteLine("a is not greater than or equal to b");
            if ((a < b) == true)
                Console.WriteLine("a is less than b");
            else
                Console.WriteLine("a is not less than b");
            if ((a <= b) == true)
                Console.WriteLine("a is less than or equal to b");
            else
                Console.WriteLine("a is not less than or equal to b");

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
