using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		Hashtable numberNames = new Hashtable();
		numberNames.Add(1, "One"); 
		numberNames.Add(2, "Two");
		numberNames.Add(3, "Three");

		

		foreach (DictionaryEntry kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		
		var cities = new Hashtable(){
			{"UK", "London, New Castle, Birmingham"},
			{"USA", "Kansas, Baltimore, Virginia"},
			{"India", "Bangalore, Warrangal, Hyderabad"}
		};

		foreach (DictionaryEntry kvp in cities)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

	}
}