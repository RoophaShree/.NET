using System;

namespace Abstract
{
    abstract class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animals sleeps well");
        }
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
            myDog.sleep();
            myPig.animalSound();
           
            myDog.animalSound();
            
        }
    }
}
