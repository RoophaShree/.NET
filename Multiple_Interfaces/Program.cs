using System;

namespace Multiple_Interfaces
{
    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("This is my inteface method");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("This is my second interface");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
