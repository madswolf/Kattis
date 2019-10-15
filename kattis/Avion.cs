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
    class Avion
    {
        static void bain(string[] args)
        {
            var output = "";
            string input;
            for (int i = 1; i < 6; i++)
            {
                input = Console.ReadLine();
                if (input.Contains("FBI")) output = output + " " + i;
            }
            if (output.Equals("")) output = "HE GOT AWAY!";
            Console.WriteLine(output.Trim());

        }

    }
}