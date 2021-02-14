using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            // 1st solution:
            Func<string, bool> func = name => name.Length <= n;
            names = names.Where(func).ToList();
            // --------------------------------------------------------

            // 2nd solution:
            // names = names.Where(name => name.Length <= n).ToList();
            // --------------------------------------------------------
            Action<List<string>> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));
            print(names);
        }
    }
}
