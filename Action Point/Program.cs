using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printNames(names);
        }
    }
}
