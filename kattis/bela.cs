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
    class Bela
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            var dominantMap = DominantMap();
            var notDominantMap = NotDominantMap();

            while (input != null)
            {
                var line = input.Split(' ');
                int count = int.Parse(line[0]);
                int output = 0;
                string dominant = line[1];
                for (int i = 0; i < count * 4; i++)
                {
                    string pair = Console.ReadLine();
                    if (pair.EndsWith(dominant))
                    {
                        output += dominantMap[pair[0].ToString()];
                    }
                    else
                    {
                        output += notDominantMap[pair[0].ToString()];
                    }
                }
                Console.WriteLine(output);
                input = Console.ReadLine();
            }
        }

        static Dictionary<string, int> DominantMap()
        {
            var map = new Dictionary<string, int>();
            map.Add("A", 11);
            map.Add("K", 4);
            map.Add("Q", 3);
            map.Add("J", 20);
            map.Add("T", 10);
            map.Add("9", 14);
            map.Add("8", 0);
            map.Add("7", 0);
            return map;
        }

        static Dictionary<string, int> NotDominantMap()
        {
            var map = new Dictionary<string, int>();
            map.Add("A", 11);
            map.Add("K", 4);
            map.Add("Q", 3);
            map.Add("J", 2);
            map.Add("T", 10);
            map.Add("9", 0);
            map.Add("8", 0);
            map.Add("7", 0);
            return map;
        }
    }
}
