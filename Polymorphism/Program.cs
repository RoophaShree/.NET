using System;

namespace Polymorphism
{

    class Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class pig : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says Oink Oink");
        }
    }
    class Dog:Animal
    {
        public void animalSound()
        {
            Console.WriteLine(" The dog says Bowww Bowww");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
