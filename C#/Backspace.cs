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
    class Backspace
    {
        static void bain(string[] args)
        {
            var line = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var character in line)
            {
                if (character == '<') stack.Pop();
                else stack.Push(character);

            }

            var output = stack.ToArray();
            Array.Reverse(output);

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}