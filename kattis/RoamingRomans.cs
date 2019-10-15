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
    class RoamingRomans
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            while (input != null)
            {
                double numberOfMiles = double.Parse(input, CultureInfo.InvariantCulture);
                Console.WriteLine(Math.Round(numberOfMiles * 1000 * 5280 / 4854));
                input = Console.ReadLine();
            }
        }

    }
}