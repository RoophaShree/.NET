using System;

namespace Automatic_Properties
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Roopa";
            Console.WriteLine(myObj.Name);
        }
    }
}
