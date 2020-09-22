using System;

namespace Interface
{

    interface IAnimal
    {
        void animalSound(); 
        void run(); 
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The Pig says: Oink Oink");
        }

        public void run()
        {
            Console.WriteLine("The pig runs very slow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.run();
        }
    }
}
