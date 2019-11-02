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
    class SimonSays
    {
        static void bain(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var line = Console.ReadLine();
                if (line.Contains("Simon says")) Console.WriteLine(line.Replace("Simon says", "").Trim());
            }

            Console.ReadLine();
        }
    }
}