using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class OddManOut
    {
        static void Bain(string[] args)
        {
            var input = Console.ReadLine();
            int count = int.Parse(input);
            for (int i = 0; i < count; i++)
            {
                var guestCount = Console.ReadLine();
                var guestIds = Console.ReadLine().Split(' ');
                var set = new HashSet<string>();
                foreach (var id in guestIds)
                {
                    if (set.Contains(id)) set.Remove(id);
                    else set.Add(id);
                }

                var output = $"Case #{i + 1}: {set.ToArray()[0]}";
                Console.WriteLine(output);
            }

            Console.ReadLine();
        }
    }
}