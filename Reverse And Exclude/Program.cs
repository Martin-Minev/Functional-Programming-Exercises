using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            numbers.Reverse();
            Func<int, bool> predicate = num => num % n != 0;
            numbers = numbers.Where(predicate).ToList();

            // numbers = numbers.Where(num => num % n != 0).ToList();
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            print(numbers);
        }
    }
}
