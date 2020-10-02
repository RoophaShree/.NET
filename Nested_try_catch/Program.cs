using System;

public class Program
{
	public static void Main()
	{
		Student std = null;

		var divider = 0;

		try
		{
			try
			{
				var result = 100 / divider;
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine("Inner catch");
			}
		}
		catch
		{
			Console.WriteLine("Outer catch");
		}
	}
}

public class Student
{

	public string StudentName { get; set; }
}