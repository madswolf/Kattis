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
    class PieceOfCake
    {
        static void bain(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var sideLength = int.Parse(line[0]);
            var distanceToHorisontalCut = int.Parse(line[1]);
            var distanceToVerticalCut = int.Parse(line[2]);

            var maximum = Math.Max(distanceToHorisontalCut * distanceToVerticalCut, (sideLength - distanceToHorisontalCut) * distanceToVerticalCut);
            maximum = Math.Max(maximum, (sideLength - distanceToHorisontalCut) * (sideLength - distanceToVerticalCut));
            maximum = Math.Max(maximum, (sideLength - distanceToVerticalCut) * distanceToHorisontalCut);

            maximum *= 4;


            Console.WriteLine(maximum);
            Console.ReadLine();
        }

    }
}