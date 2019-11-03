using System;
using System.CodeDom;
using System.Collections;
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
    class SortOfSorting
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            while (true)
            {
                var arr = new string[counter];

                for (int i = 0; i < counter; i++)
                {
                    arr[i] = Console.ReadLine();
                }
                Array.Sort(arr, Comparer<String>.Create((s1, s2) => (s1[0] * 1000 + s1[1]).CompareTo(s2[0] * 1000 + s2[1])));

                var output = new StringBuilder();
                foreach (var entry in arr)
                {
                    output.Append(entry + "\n");
                }

                Console.Write(output);
                counter = int.Parse(Console.ReadLine());
                if (counter == 0) break;
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}