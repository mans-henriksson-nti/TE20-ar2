﻿using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine($"FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine($"Fizz");
                        
                    }
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine($"Buzz");
                    }
                    else
                    {
                        Console.WriteLine($"{i}");
                        
                    }
                }
            }
        }
    }
}