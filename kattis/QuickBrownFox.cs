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
    class QuickBrownFox
    {
        static void bain(string[] args)
        {
            var input = int.Parse(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                var line = new string((
                    from c in Console.ReadLine()
                    where char.IsLetter(c)
                    select c
                ).ToArray()).ToLower();
                var alphabet = Alphabet();
                foreach (var character in line)
                {
                    alphabet[character]++;
                }

                var output = "";
                foreach (var c in alphabet)
                {
                    if (c.Value == 0) output += c.Key;
                }

                if (output.Equals("")) Console.WriteLine("pangram");
                else Console.WriteLine("missing " + output);
            }

            Console.ReadLine();
        }
        public static Dictionary<char, int> Alphabet()
        {
            var alphabet = new Dictionary<char, int>();
            var alphabetString = "abcdefghijklmnopqrstuvwxyz";
            foreach (var character in alphabetString)
            {
                alphabet.Add(character, 0);
            }

            return alphabet;
        }
    }
}