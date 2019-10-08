using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class the
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (!input.Equals("0"))
            {
                int setSize = int.Parse(input);
                var set = new List<int>();
                for (int i = 0; i < setSize; i++)
                {
                    set.Add(int.Parse(Console.ReadLine()));   
                }
                set = ArrangeSymmetricly(set);
            }
        }

        public static List<int> ArrangeSymmetricly(List<int> set)
        {
            set.Sort();
            return set;
        }
    }
}
