using System;
using System.Linq;


namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string
                .Join("\n", Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => Char.IsUpper(x[0]))));
        }
    }
}
