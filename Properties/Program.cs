using System;
using System.Reflection.Metadata.Ecma335;

namespace Properties
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Name = "Roopa";
            Console.WriteLine(myPerson.Name);
        }
    }
}
