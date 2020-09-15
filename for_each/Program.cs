using System;

namespace for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] grocery = { "milk", "chocolate", "flowers", "biscuits" };
            foreach(string i in grocery)
            {
                Console.WriteLine(i);
            }
        }
    }
}
