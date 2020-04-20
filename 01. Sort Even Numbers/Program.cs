﻿using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(", ")
                .Select(Int32.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)));
        }
    }
}
