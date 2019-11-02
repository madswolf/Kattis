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
    class StandZanzibar
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            while (input != null)
            {
                var count = int.Parse(input);
                for (int i = 0; i < count; i++)
                {
                    var line = Console.ReadLine().Split(' ');
                    var output = 0;
                    int lastnumber = int.Parse(line[0]);
                    int currentNumber;

                    for (int j = 1; j < line.Length - 1; j++)
                    {
                        currentNumber = int.Parse(line[j]);
                        var import = currentNumber - lastnumber * 2;
                        if (import > 0)
                        {
                            output += import;
                        }
                        lastnumber = currentNumber;
                    }

                    Console.Out.WriteLine(output);
                }
                input = Console.ReadLine();
            }
        }
    }
}