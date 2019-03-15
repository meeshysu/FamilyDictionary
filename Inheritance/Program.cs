using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Alex" }, { "age", "26" } });
            myFamily.Add("half-brother", new Dictionary<string, string>() { { "name", "Daniel" }, { "age", "34" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Edward" }, { "age", "63" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Stacey" }, { "age", "62" } });

            foreach (var (relationship, info) in myFamily)
            {
                Console.WriteLine($"{info["name"]} is my {relationship} and is {info["age"]}.");
            }
            Console.ReadLine();
        }
    }
}
