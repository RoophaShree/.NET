#define PRINT_MSG_TYPE1

using System;
class Program
{
    static void Main()
    {
#if PRINT_MSG_TYPE1
        Console.WriteLine("Print message type1 on console screen");
#endif

#if PRINT_MSG_TYPE2
            Console.WriteLine("Print message type2 on console screen");
#endif
    }
}