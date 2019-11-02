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
    class Aaah
    {
        static void bain(string[] args)
        {

            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            if (line2.Length > line1.Length) Console.WriteLine("no");
            else Console.WriteLine("go");
            Console.ReadLine();
        }
    }
}