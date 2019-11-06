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
    class Babelfish
    {
        static void bain(string[] args)
        {
            var input = "";
            var map = new Dictionary<string, string>();
            while (!(input = Console.ReadLine()).Equals(""))
            {
                var pair = input.Split(' ');
                map[pair[1]] = pair[0];
            }

            while ((input = Console.ReadLine()) != null)
            {
                if (map.ContainsKey(input)) Console.WriteLine(map[input]);
                else Console.WriteLine("eh");
            }
            Console.ReadLine();
        }

    }
}