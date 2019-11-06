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
    class Recount
    {
        static void bain(string[] args)
        {
            var input = "";
            var map = new Dictionary<string, int>();
            int count = 0;
            while (!(input = Console.ReadLine()).Equals("***"))
            {
                if (!map.ContainsKey(input)) map[input] = 1;
                else map[input]++;
                count++;
            }

            var output = "";
            var maximum = int.MinValue;
            foreach (var pair in map)
            {
                if (pair.Value > maximum)
                {
                    maximum = pair.Value;
                    output = pair.Key;
                }
                else if (pair.Value == maximum)
                {
                    output = "Runoff!";
                }
            }

            if (output.Equals("")) output = "Runoff!";
            Console.WriteLine(output);
            Console.ReadLine();
        }

    }
}