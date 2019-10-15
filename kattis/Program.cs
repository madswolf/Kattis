using System;
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
    class MixedFractions
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var count = int.Parse(input);
            for (int i = 0; i < count; i++)
            {
                var msg = Console.ReadLine();
                var squareSize = (int)Math.Sqrt(msg.Length);
                var output = new StringBuilder();
                for (int j = squareSize - 1; j >= 0; j--)
                {
                    for (int k = j; k < msg.Length; k += squareSize)
                    {
                        output.Append(msg[k]);
                    }
                }
                Console.WriteLine(output);
            }
            input = Console.ReadLine();
        }

    }
}