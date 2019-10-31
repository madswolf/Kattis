using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class ABC
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            var order = Array.ConvertAll(input.Split(' '), x => int.Parse(x));

            Array.Sort(order);
            int a = order[0];
            int b = order[1];
            int c = order[2];
            var map = new Dictionary<char, int>();
            map['A'] = a;
            map['B'] = b;
            map['C'] = c;

            var line = Console.ReadLine();
            var output = new StringBuilder();
            foreach (var character in line)
            {
                output.Append(map[character] + " ");
            }
            Console.WriteLine(output.ToString().Trim());

            Console.ReadLine();
        }
    }
}