using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> numbers = Enumerable.Range(1, end).ToList();
            Func<int, int, bool> predicate = (number, div) => number % div == 0; 
            foreach (int number in numbers)
            {
                // if (dividers.All(div => number % div == 0))
                if (dividers.All(div => predicate ( number, div)))
                    {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
