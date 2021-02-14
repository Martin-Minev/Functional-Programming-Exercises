using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(nums.Min());
        }
    }
}
