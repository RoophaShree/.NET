using System;

public class Program
{
	public static void Main()
	{
		var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
		Console.WriteLine(numbers.Item1); 
		Console.WriteLine(numbers.Item7); 
		Console.WriteLine(numbers.Rest.Item1); 
		Console.WriteLine(numbers.Rest.Item1.Item1); 
		Console.WriteLine(numbers.Rest.Item1.Item2); 
	}
}