using System;

namespace Structure
{
    struct structure
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nDeclare a simple structure:\n");
            Console.WriteLine("---------------------------------\n");
            structure st = new structure();
            st.x = 15;
            st.y = 20;
            int sum = st.x + st.y;
            Console.WriteLine("The sum of x and y is " +sum);
        }
    }
}
