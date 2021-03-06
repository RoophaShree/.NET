﻿using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine(queue.Contains(4));
            Console.WriteLine(queue.Contains(6));
            Console.WriteLine(queue.Contains(10));
            Console.WriteLine("\n");


            foreach (var num in queue)
                Console.WriteLine(num);

            Queue<string> que = new Queue<string>();
            que.Enqueue("H");
            que.Enqueue("E");
            que.Enqueue("L");
            que.Enqueue("L");
            que.Enqueue("O");

            Console.WriteLine("Total Elements:", +que.Count);

            if(que.Count>0)
            {
                Console.WriteLine(que.Peek());
                Console.WriteLine(que.Peek());
                Console.WriteLine("\n");
            }

            while(que.Count>0)
            {
                Console.WriteLine(que.Dequeue());
            }

            Console.WriteLine("The total elements after Dequeue: {0}", que.Count);

        }
    }
}
