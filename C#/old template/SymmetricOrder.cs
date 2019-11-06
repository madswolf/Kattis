using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class SymmetricOrder
    {
        static void bain(string[] args)
        {
            var input = Console.ReadLine();
            int setNumber = 1;
            while (!input.Equals("0"))
            {
                int setSize = int.Parse(input);
                var set = new List<string>();
                for (int i = 0; i < setSize; i++)
                {
                    set.Add(Console.ReadLine());   
                }
                var symmetricOutput = ArrangeSymmetricly(set);
                Console.WriteLine($"SET {setNumber}");
                foreach (var name in symmetricOutput)
                {
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
                setNumber++;
            }
        }

        public static string[] ArrangeSymmetricly(List<string> set)
        {
            Array.Sort(set.ToArray(), (x, y) => x.Length.CompareTo(y.Length));
            int lower = 0;
            int upper = set.Count - 1;
            string[] output = new string[set.Count];
            for (int i = 0; i < set.Count; i++)
            {
                if (i % 2 == 0)
                {
                    output[lower] = set[i];
                    lower++;
                }
                else
                {
                    output[upper] = set[i];
                    upper--;
                }
            }
            
            return output;
        }
    }
}