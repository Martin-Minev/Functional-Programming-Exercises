using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Func<string, char[]> stringToCharArray = name => name.ToCharArray();
            Func<char, int> castFunc = charName => (int)charName;
            Func<string, bool> resultFunc = name => stringToCharArray(name)
                                           .Select(castFunc)
                                           .Sum() >= n;
            Console.WriteLine(Console.ReadLine()
                .Split()
                .FirstOrDefault(resultFunc));
        }
    }
}
