using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, (a, b) =>
            {
                // a - odd , b - even
                if (a % 2 != 0 && b % 2 == 0)
                {
                    return 1;
                }
                // a - even , b - odd
                else if (a % 2 == 0 && b % 2 != 0)
                {
                    return -1;
                }
                return a.CompareTo(b);
            });
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            print(numbers);
        }
    }
}
