using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<int, int> arithmeticFunc = num => num;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    arithmeticFunc = num => num + 1;
                    numbers = numbers.Select(num => arithmeticFunc(num)).ToList();
                }
                else if (command == "multiply")
                {
                    arithmeticFunc = num => num * 2;
                    numbers = numbers.Select(num => arithmeticFunc(num)).ToList();
                }
                else if (command == "subtract")
                {
                    arithmeticFunc = num => num - 1;
                    numbers = numbers.Select(num => arithmeticFunc(num)).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
