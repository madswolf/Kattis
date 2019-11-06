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
    class ThreeDPrinter
    {
        static void bain(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var counter = 1;
            var iterations = 0;
            while (counter < number)
            {
                counter *= 2;
                iterations++;
            }

            Console.WriteLine(iterations + 1);

            Console.ReadLine();

        }

    }
}