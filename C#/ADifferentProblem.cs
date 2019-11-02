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
    class ADifferentProblem
    {
        static void bain(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {

                var line = input.Split(' ');

                var x = ulong.Parse(line[0]);
                var y = ulong.Parse(line[1]);

                if (x > y)
                {
                    Console.WriteLine(x - y);
                }
                else
                {
                    Console.WriteLine(y - x);
                }
            }
        }
    }
}