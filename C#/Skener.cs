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
    class Skener
    {
        static void bain(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var rowCount = int.Parse(line[0]);
            var columnCount = int.Parse(line[1]);
            var rowMagnification = int.Parse(line[2]);
            var columnMagnification = int.Parse(line[3]);


            var output = new StringBuilder();

            for (int i = 0; i < rowCount; i++)
            {
                var input = Console.ReadLine();
                var currentLine = new StringBuilder();
                foreach (var character in input)
                {
                    for (int j = 0; j < columnMagnification; j++)
                    {
                        currentLine.Append(character);
                    }
                }

                currentLine.Append("\n");
                for (int j = 0; j < rowMagnification; j++)
                {
                    output.Append(currentLine);
                }
            }

            Console.WriteLine(output);
            //var x = Console.ReadLine();
        }

    }
}