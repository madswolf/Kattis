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
    class ANewAlphabet
    {
        static void bain(string[] args)
        {
            var line = Console.ReadLine().ToLower();

            var alphabet = Alphabet();
            var output = new StringBuilder();

            foreach (var character in line)
            {

                if (!alphabet.Keys.Contains(character))
                {
                    output.Append(character);
                }
                else
                {
                    output.Append(alphabet[character]);
                }

            }
            Console.WriteLine(output);

            Console.ReadLine();
        }
        public static Dictionary<char, string> Alphabet()
        {
            var alphabet = new Dictionary<char, string>();
            alphabet['a'] = "@";
            alphabet['b'] = "8";
            alphabet['c'] = "(";
            alphabet['d'] = "|)";
            alphabet['e'] = "3";
            alphabet['f'] = "#";
            alphabet['g'] = "6";
            alphabet['h'] = "[-]";
            alphabet['i'] = "|";
            alphabet['j'] = "_|";
            alphabet['k'] = "|<";
            alphabet['l'] = "1";
            alphabet['m'] = @"[]\/[]";
            alphabet['n'] = @"[]\[]";
            alphabet['o'] = "0";
            alphabet['p'] = "|D";
            alphabet['q'] = "(,)";
            alphabet['r'] = "|Z";
            alphabet['s'] = "$";
            alphabet['t'] = "']['";
            alphabet['u'] = "|_|";
            alphabet['v'] = @"\/";
            alphabet['w'] = @"\/\/";
            alphabet['x'] = "}{";
            alphabet['y'] = "`/";
            alphabet['z'] = "2";


            return alphabet;
        }
    }
}
