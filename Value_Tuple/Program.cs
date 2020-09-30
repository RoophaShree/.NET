using System;

public class Program
{
	public static void Main()
	{
		var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);

		Console.WriteLine(numbers.Item1);
		Console.WriteLine(numbers.Item2);
		Console.WriteLine(numbers.Item3); 
		Console.WriteLine(numbers.Item3.Item1); 
		Console.WriteLine(numbers.Item4); 
		Console.WriteLine(numbers.Rest.Item1); 


	}
}