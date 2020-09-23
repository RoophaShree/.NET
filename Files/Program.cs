
using System;
using System.IO;  

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeAllBytes = "Hi RoophaShree, how are you?";
            File.WriteAllBytes("fname.txt", writeAllBytes);

            string readText = File.ReadAllText("filename.txt"); 
            Console.WriteLine(readText);
        }
    }
}