using System;

namespace Smallest_num
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			int small = 0;
		
			int[] arr = new int[5];

			Console.WriteLine("Enter array elements : ");
			
			for (i = 0; i < arr.Length; i++)
			{
				Console.Write("Element[" + (i + 1) + "]: ");
				arr[i] = int.Parse(Console.ReadLine());
			}

			
			small = arr[0];

			for (i = 1; i < arr.Length; i++)
			{
				
				if (small > arr[i])
					small = arr[i];
			}

			//finally print the smallest elemeent of the integer array
			Console.WriteLine("Smallest element in array is : " + small);
		}
	}
}
