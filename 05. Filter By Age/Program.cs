using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main()
        {
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
            int personNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < personNumber; i++)
            {
                string[] info = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new KeyValuePair<string, int>(info[0], int.Parse(info[1])));
            }

            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string filter = Console.ReadLine();
            List<string> result = new List<string>();

            if (type == "younger")
            {
                people = people.Where(x => x.Value < age).ToList();
            }
            else
            {
                people = people.Where(x => x.Value >= age).ToList();
            }

            Print(people, filter);
        }
        static void Print (List<KeyValuePair<string, int>> people, string filter)
        {
            string text;
            foreach (var (name, age) in people)
            {
                if (filter == "name age")
                {
                    text = $"{name} - {age}";
                }
                else if (filter == "age")
                {
                    text = $"{age}";
                }
                else
                {
                    text = name;
                }
                Console.WriteLine(text);
            }
        }
    }
}
