using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class StackingCups
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            while (input != null)
            {
                int count = int.Parse(input);
                List<(int, string)> list = new List<(int, string)>();
                
                for (int i = 0; i < count; i++)
                {
                    var line = Console.ReadLine().Split(' ');

                    int number;
                    if (int.TryParse(line[0], out number))
                    {
                        list.Add((number/2, line[1]));
                    }
                    else
                    {
                        number = int.Parse(line[1]);
                        list.Add((number,line[0]));
                    }
                    
                }
                list.Sort((x, y) => x.Item1.CompareTo(y.Item1));
                foreach (var item in list)
                {
                    Console.WriteLine(item.Item2);
                }
                input = Console.ReadLine();
            }
        }
    }
}