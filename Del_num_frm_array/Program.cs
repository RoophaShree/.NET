using System;

namespace Del_num_frm_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pos = -1;
            int item = 0;

            int[] arr1 = new int[5];

            
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter item to delete : ");
            item = int.Parse(Console.ReadLine());

            for (i = 0; i < 5; i++)
            {
                if (item == arr1[i])
                {
                    pos = i;
                    break;
                }
            }

            if (pos == -1)
            {
                Console.WriteLine("Element did not find in array");
            }
            else
            {
                
                for (i = pos; i < arr1.Length - 1; i++)
                {
                    arr1[i] = arr1[i + 1];
                }
                Console.WriteLine("Array elements after deletion : ");
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("Element[" + (i + 1) + "]: " + arr1[i]);

                }
            }
            Console.WriteLine();
        }
    }
}
            
        

