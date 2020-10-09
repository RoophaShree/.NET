using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "MainThread";
            Console.WriteLine(t.Name);
        }
    }
}
