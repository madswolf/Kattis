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
    class WhatFoxSays
    {
        static void bain(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var output = Console.ReadLine().Split(' ');
                var line = Console.ReadLine();

                while (!line.EndsWith("?"))
                {
                    var sound = line.Substring(line.IndexOf("goes") + 5);
                    for (int j = 0; j < output.Length; j++)
                    {
                        if (output[j].Equals(sound)) output[j] = "";
                    }

                    line = Console.ReadLine();
                }

                var foxGoes = "";

                foreach (var word in output)
                {
                    if (word.Equals("")) continue;
                    foxGoes += word + " ";
                }
                Console.WriteLine(foxGoes);
            }


            Console.ReadLine();
        }

    }
}