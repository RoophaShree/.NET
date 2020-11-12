using System;

namespace GOTO_Stmt
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int power = 0;
            int result = 0;
            int choice = 0;
       // LOOP_LABEL:

            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Enter power: ");
            power = int.Parse(Console.ReadLine());

            result = (int)Math.Pow(number, power);

            Console.WriteLine("Result : " + result);

            Console.WriteLine("Do you want to calculate power again?? Press 1 for Yes, Press 2 for No: ");
            choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
              //  goto LOOP_LABEL;
        }
    }
}
