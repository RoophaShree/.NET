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

			//assign fist element to the 'small' 
			//compare it with other array elements
			small = arr[0];

			for (i = 1; i < arr.Length; i++)
			{
				//compare if small is greater than of any element of the array
				//assign that element in it.
				if (small > arr[i])
					small = arr[i];
			}

			//finally print the smallest elemeent of the integer array
			Console.WriteLine("Smallest element in array is : " + small);
		}
	}
}
