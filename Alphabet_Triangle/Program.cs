﻿using System;
public class Albhabet
{
    public static void Main(string[] args)
    {
        char ch = 'A';
        int i, j, k, m;
        for (i = 1; i <= 6; i++)
        {
            for (j = 6; j >= i; j--)
                Console.Write(" ");
            for (k = 1; k <= i; k++)
                Console.Write(ch++);
            ch--;
            for (m = 1; m < i; m++)
                Console.Write(--ch);
            Console.Write("\n");
            ch = 'A';
        }
    }
}