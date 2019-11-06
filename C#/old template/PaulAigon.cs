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
    class PaulAigon
    {
        static void bain(string[] args)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(' '), c => long.Parse(c));

            var servesPerSwitch = line[0];
            var roundCount = line[1] + line[2];

            var switchCount = (double)roundCount / servesPerSwitch;
            Console.WriteLine(switchCount);
            if (switchCount % 2 >= 0 && switchCount % 2 < 1) Console.WriteLine("paul");
            else Console.WriteLine("opponent");

            Console.ReadLine();
        }
    }
}