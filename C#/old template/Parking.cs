using System;
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
    class parking
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            for (int i = 0; i < int.Parse(input); i++)
            {
                var count = float.Parse(Console.ReadLine());
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                var distance = 0;

                Array.Sort(line);

                for (int j = 1; j <= count; j++)
                {
                    distance += j == count ? line[j - 1] - line[0] : line[j] - line[j - 1];
                }

                Console.WriteLine(distance);
            }
        }

    }
}