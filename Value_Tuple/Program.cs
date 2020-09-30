using System;

public class Program
{
    static void Main(string[] args)
    {
        var person = GetPerson();
        Console.WriteLine($"Id = { person.Item1}");
        Console.WriteLine($"First Name = { person.Item2}");
        Console.WriteLine($"Last Name = { person.Item3}");
    }

    static Tuple<int, string, string> GetPerson()
    {
        return Tuple.Create(1, "Bill", "Gates");
    }
}