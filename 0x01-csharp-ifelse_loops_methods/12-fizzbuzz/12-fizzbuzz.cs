﻿using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (; i < 101; i++)
            {
                if  (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz");
                else if  (i % 3 == 0)
                    Console.Write("Fizz");
                else if  (i % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write(i);
                
                if (i != 100)
                    Console.Write(" ");
                else
                    Console.WriteLine();
            }
        }
    }
}
