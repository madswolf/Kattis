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
    class LostLineup
    {
        static void Main(string[] args)
        {
            var line = int.Parse(Console.ReadLine());
            
            var lineup = new int[line];
            lineup[0] = 1;
            var input = Console.ReadLine();
            if (!input.Equals(""))
            {
                var order = Array.ConvertAll(input.Split(' '), c => int.Parse(c));
                int start = 2;
                foreach (var placement in order)
                {
                    lineup[placement + 1] = start;
                    start++;
                }
            }

            var output = "";

            foreach (var person in lineup)
            {
                output += person + " ";
            }

            Console.WriteLine(output.Trim());
            Console.ReadLine();
        }

    }
}