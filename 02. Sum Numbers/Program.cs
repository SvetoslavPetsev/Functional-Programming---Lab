using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(ParseInt)
                .ToArray();

            int count = numbers.Length;
            int sum = numbers.Sum();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
        public static Func<string, int> ParseInt = n =>
        {
            int result = 0;
            if (Int32.TryParse(n, out result))
            {
                return result;
            }
            return result;
        }; 

    }   
}
