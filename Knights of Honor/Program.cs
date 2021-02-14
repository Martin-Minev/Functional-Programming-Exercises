using System;
using System.Collections.Generic;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st solution:

            //string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //Func<string, string> func = name => $"Sir {name}";

            //foreach (var name in names)
            //{
            //    Console.WriteLine(func(name));
            //}---------------------------------------------------------------------------------------

            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> newNames = names.Select(name => $"Sir {name}").ToList();
            // 2nd solution
            // Console.WriteLine(string.Join(Environment.NewLine, newNames));
            //------------------------------------------------------------------------------------------
            // 3rd solution
            Action < List<string> > printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printNames(newNames);

        }
        static void printNamesMethod(List<string> names)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
