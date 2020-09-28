using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		ArrayList arlist = new ArrayList()
						{
							1,
							"Bill",
							"Roopa",
							"Vicky",
							3.5F,
						};

		Console.WriteLine("foreach loop");
		foreach (var item in arlist)
			Console.Write(item + ", "); 

		Console.WriteLine("\n");
		Console.WriteLine("for loop");

		for (int i = 0; i < arlist.Count; i++)
			Console.Write(arlist[i] + ", ");
	}
}