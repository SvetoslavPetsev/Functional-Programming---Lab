using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();
            foreach (var num in numbers)
            {
                Console.WriteLine($"{num:F2}");
            }
        }
    }
}
