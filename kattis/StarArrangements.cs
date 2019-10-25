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
    class StarArrangements
    {
        static void bain(string[] args)
        {
            var StarCount = int.Parse(Console.ReadLine());
            UInt32 x = 2;
            UInt32 y = 1;
            var output = new StringBuilder(StarCount + ":\n");

            while (x < StarCount)
            {


                var counter = x + y;
                while (counter <= StarCount)
                {

                    if (counter == StarCount)
                    {
                        output.Append($"{x},{y}\n");
                    }

                    counter += x;

                    if (counter == StarCount)
                    {
                        output.Append($"{x},{y}\n");
                    }

                    counter += y;
                }

                y++;

                counter = x + y;
                while (counter <= StarCount)
                {
                    if (counter == StarCount)
                    {
                        output.Append($"{x},{y}\n");
                    }

                    counter += x;

                    if (counter == StarCount)
                    {
                        output.Append($"{x},{y}\n");
                    }

                    counter += y;
                }

                x++;
            }

            Console.WriteLine(output);
            var input = Console.ReadLine();
        }

    }
}