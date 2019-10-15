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
    class ReverseRot
    {
        static void bain(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.".ToCharArray();
            var input = Console.ReadLine();
            while (!input.Equals("0"))
            {
                var line = input.Split(' ');
                var rot = int.Parse(line[0]);
                var msg = line[1];
                var reverse = "";
                for (int i = msg.Length - 1; i >= 0; i--)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (msg[i] == alphabet[j])
                        {
                            reverse += alphabet[(j + rot) % alphabet.Length];
                            break;
                        }
                    }
                }
                Console.WriteLine(reverse);
                input = Console.ReadLine();
            }

        }

    }
}