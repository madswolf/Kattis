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
    class Beavergnaw
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine().Split(' ');


                var D = int.Parse(line[0]);
                var V = int.Parse(line[1]);

                if (D == 0 && V == 0) break;

                var d3 = Math.Pow(D, 3) - 6 * V / Math.PI;
                var d = Math.Pow(d3, (1 / 3.0));


                Console.WriteLine(d);
            }

            Console.ReadLine();
        }

    }
}