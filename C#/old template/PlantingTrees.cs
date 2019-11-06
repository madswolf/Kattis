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
    class PlantingTrees
    {
        static void bain(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();

            var order = Array.ConvertAll(line.Split(' '), c => Int64.Parse(c));
            Array.Sort(order);
            Array.Reverse(order);

            for (int i = 0; i < input; i++)
            {
                order[i] += i + 2;
            }

            Console.WriteLine(order.Max());
            Console.ReadLine();
        }
    }
}