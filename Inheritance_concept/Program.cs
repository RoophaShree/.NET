using System;
namespace Inheritance_concept
{

    class Roopa
    {
        public string name;
        public string subject;


        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
        class Masters : Roopa
        {

            public Masters()
            {
                Console.WriteLine("Masters in Big Data");
            }
        }

        class Program
        {


            static void Main(string[] args)
            {

                Masters m = new Masters();


                m.readers("RoopaShree", "C#");
            }
        }
    }
}