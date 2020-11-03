using System;


namespace Hash_define_preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
#if PRINT_MSG_TYPE1
            Console.WriteLine("Print message type1 on console screen");
#endif

#if PRINT_MSG_TYPE2
            Console.WriteLine("Print message type2 on console screen");
#endif
        }
    }
}
    
