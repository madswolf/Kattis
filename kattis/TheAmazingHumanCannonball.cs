using System;
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
    class TheAmazingHumanCannonball
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();

            var count = int.Parse(input);
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var velocity = double.Parse(line[0], CultureInfo.InvariantCulture);
                var angle = double.Parse(line[1], CultureInfo.InvariantCulture);
                var holeX = double.Parse(line[2], CultureInfo.InvariantCulture);
                var holeY1 = double.Parse(line[3], CultureInfo.InvariantCulture);
                var holeY2 = double.Parse(line[4], CultureInfo.InvariantCulture);

                var output = "Not Safe";
                double t = holeX / velocity / Math.Cos(ToRadians(angle));
                double y = velocity * t * Math.Sin(ToRadians(angle)) - 4.905 * Math.Pow(t, 2);
                /* Console.WriteLine(t);
                 Console.WriteLine(y);
                 Console.WriteLine(y - holeY1);
                 Console.WriteLine(holeY2 - y);*/

                if (y - holeY1 >= 1 && holeY2 - y >= 1)
                {
                    output = "Safe";
                }

                Console.WriteLine(output);
            }
            input = Console.ReadLine();
        }
        public static double ToRadians(double val)
        {
            return (Math.PI / 180.0) * val;
        }

    }
}