#define MY_MACRO
using System;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
#if (MY_MACRO)
        Console.WriteLine("Macro is defined");
#else
            Console.WriteLine("Macro is not defined");
#endif
    }
}