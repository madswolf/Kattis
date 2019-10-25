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
    class ProvincesAndGold
    {
        static void bain(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var goldCount = int.Parse(line[0]);
            var silverCount = int.Parse(line[1]);
            var copperCount = int.Parse(line[2]);

            var buyingPower = goldCount * 3 + silverCount * 2 + copperCount * 1;

            var output = "";
            if (buyingPower >= 8)
            {
                output = "Province";
            }
            else if (buyingPower >= 5)
            {
                output = "Duchy";
            }
            else if (buyingPower >= 2)
            {
                output = "Estate";
            }

            if (!output.Equals("")) output += " or ";

            if (buyingPower >= 6)
            {
                output += "Gold";
            }
            else if (buyingPower >= 3)
            {
                output += "Silver";
            }
            else
            {
                output += "Copper";
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }

    }
}