using System;
using System.Collections;

namespace Access_Stack_using_Pop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(5);

            Console.WriteLine("Number of elements in stack are:", + myStack.Count);

            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop() + ",");

            Console.WriteLine("Number of elements in stack after pop operation is:{0}", myStack.Count);

        }
    }
}
