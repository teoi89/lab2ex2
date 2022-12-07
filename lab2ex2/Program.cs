﻿using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa factorialul unui numar n, n fiind citit
                de la tastatura. */
            
            Console.WriteLine("Insert a number:");
            
            ulong n = ulong.Parse(Console.ReadLine());
            ulong factorial = 1;

            while (n > 0)
            {
                factorial = factorial * n;
                n = n - 1;
            }
            Console.WriteLine("You number is: " + factorial);
        }
    }
}
