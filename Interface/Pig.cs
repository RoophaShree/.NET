using System;

namespace Interface
{
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
}
