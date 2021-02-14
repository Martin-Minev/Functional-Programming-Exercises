using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "Party!")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string filterCommand = tokens[1];
                string criteria = tokens[2];
                Func<string, string, bool> predicate = GetFunc(filterCommand);

                switch (command)
                {
                    case "Remove":
                        names = names.Where(x => !predicate(x, criteria)).ToList();
                        break;

                    case "Double":
                        List<string> guestToAdd = new List<string>();
                        guestToAdd = names.Where(x => predicate(x, criteria)).ToList();
                        foreach (var name in guestToAdd)
                        {
                            int index = names.IndexOf(name);
                            names.Insert(index + 1, name);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            if (names.Any())
            {
                Console.Write(string.Join(", ", names));
                Console.Write(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Func<string, string, bool> GetFunc(string filterCommand)
        {
            if (filterCommand == "StartsWith")
            {
                return (x, c) => x.StartsWith(c);
            }
            else if (filterCommand == "EndsWith")
            {
                return (x, c) => x.EndsWith(c);
            }
            else if (filterCommand == "Length")
            {
                return (x, c) => x.Length == int.Parse(c);
            }
            return null;
        }
    }
}
