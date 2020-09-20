using System;

namespace Abstract
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("ZZZZzzzzzzzzzzzz");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: Oink Oink");
        }
    }
    
    class Dog: Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: Bow bowwww");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            Dog myDog = new Dog();
            myPig.animalSound();
            myPig.sleep();
            myDog.animalSound();
            myDog.sleep();
        }
    }
}
