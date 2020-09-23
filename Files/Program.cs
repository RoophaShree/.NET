
using System;
using System.IO;  

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hi RoophaShree, how are you?";  
            File.WriteAllText("filename.txt", writeText);  

            string readText = File.ReadAllText("filename.txt"); 
            Console.WriteLine(readText);
        }
    }
}