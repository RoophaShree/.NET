
using System;
using System.IO;  

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeAllText = "Hi RoophaShree, how are you?";
            File.WriteAllText("fname.txt", writeAllText);

            string readText = File.ReadAllText("filename.txt"); 
            Console.WriteLine(readText);
        }
    }
}