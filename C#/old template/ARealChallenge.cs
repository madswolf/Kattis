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
    class ARealChallenge
    {
        static void bain(string[] args)
        {
            var input = UInt64.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(input) * 4);
            Console.ReadLine();
        }
    }
}