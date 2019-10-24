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
    class SumSquaredDigits
    {
        static void bain(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var numberBase = int.Parse(line[1]);
                var number = int.Parse(line[2]);

                var result = 0;

                while (number > 0)
                {
                    var remainder = number % numberBase;
                    result += remainder * remainder;
                    number /= numberBase;
                }

                Console.WriteLine(i + 1 + " " + result);
            }
            var input = Console.ReadLine();
        }

    }
}