using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = ranges[0];
            int end = ranges[1];
            string criteria = Console.ReadLine();
            Func<int, int, List<int>> generateRangeOfNums = (s, e) =>
            {
                List<int> nums = new List<int>();
                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }
                return nums;
            };
            List<int> numbers = generateRangeOfNums(start, end);
            Predicate<int> predicate = n => true;
            if (criteria=="odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }
            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));
        }

        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();
            foreach (var currentNum in numbers)
            {
                if (predicate(currentNum))
                {
                    newNumbers.Add(currentNum);
                }
            }
            return newNumbers;
        }
    }
}
