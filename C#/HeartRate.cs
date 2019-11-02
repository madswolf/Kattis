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
    class HeartRate
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            while (input != null)
            {
                var count = int.Parse(input);
                for (int i = 0; i < count; i++)
                {
                    var line = Console.ReadLine().Split(' ');

                    var b = double.Parse(line[0], CultureInfo.InvariantCulture);
                    var p = double.Parse(line[1], CultureInfo.InvariantCulture);

                    var bpm = 60 * b / p;
                    var minBpm = bpm - (60 / p);
                    var maxBpm = bpm + (60 / p);

                    Console.WriteLine($"{minBpm} {bpm} {maxBpm}");
                }
                input = Console.ReadLine();
            }
        }
    }
}