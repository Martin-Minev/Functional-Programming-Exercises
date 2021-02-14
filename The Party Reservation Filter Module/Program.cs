using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();
            List<string> filters = new List<string>();

            while (command != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string typeCommand = tokens[0];
                string filterType = tokens[1];
                string filterParameter = tokens[2];

                if (typeCommand == "Add filter")
                {
                    filters.Add($"{filterType};{filterParameter}");
                }

                else if (typeCommand == "Remove filter")
                {
                    filters.Remove($"{filterType};{filterParameter}");
                }
                command = Console.ReadLine();
            }

            foreach (var item in filters)
            {
                string[] infos = item.Split(";");
                string filterType = infos[0];
                string filterParameter = infos[1];

                Func<string, string, bool> predicate = GetFunc(filterType);
                guestList = guestList.Where(g => !predicate(g, filterParameter)).ToList();
            }
            Console.WriteLine(string.Join(" ", guestList));
        }

        static Func<string, string, bool> GetFunc (string filterType)
        {
            if (filterType == "Starts with")
            {
                return (g, p) => g.StartsWith(p);
            }

            else if (filterType == "Ends with")
            {
                return (g, p) => g.EndsWith(p);
            }
            else if (filterType == "Length")
            {
                return (g, p) => g.Length== int.Parse(p);
            }
            else if (filterType == "Contains")
            {
                return (g, p) => g.Contains(p);
            }
            return null;
        }
    }
}
