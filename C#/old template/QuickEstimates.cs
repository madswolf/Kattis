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
    class QuickEstiamtes
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            while (input != null)
            {
                var count = int.Parse(input);
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(Console.ReadLine().Length);
                }
                input = Console.ReadLine();
            }

        }

    }
}