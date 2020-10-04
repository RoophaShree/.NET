using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>();

		dict.Add(4, "four");
		dict.Add(5 , "five");
		dict.Add(6, "six");

		Hashtable ht = new Hashtable(dict);

		Console.WriteLine("Total elements: {0}", ht.Count);

	}
}