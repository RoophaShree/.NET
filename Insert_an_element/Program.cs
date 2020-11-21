using System;

namespace Insert_an_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pos = 0;
            int item = 0;
            int[] arr = new int[10];

            
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());
        }
    }
}
