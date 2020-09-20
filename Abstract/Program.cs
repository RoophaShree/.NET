using System;

namespace Abstract
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("ZZZZzzzzzzzzzzzz");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
