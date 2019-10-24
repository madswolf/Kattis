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
    class Ptice
    {
        static void bain(string[] args)
        {
            var AdrianPattern = "ABC";
            var BrunoPattern = "BABC";
            var GoranPattern = "CCAABB";
            var sutPik = Console.ReadLine();
            var input = Console.ReadLine();
            var highestAccuracy = Accuracy(input, AdrianPattern);
            var Name = "Adrian";
            if (highestAccuracy == Accuracy(input, BrunoPattern))
            {
                Name += "\nBruno";
            }
            else if (highestAccuracy < Accuracy(input, BrunoPattern))
            {
                highestAccuracy = Accuracy(input, BrunoPattern);
                Name = "Bruno";
            }
            if (highestAccuracy == Accuracy(input, GoranPattern))
            {
                Name += "\nGoran";
            }
            else if (highestAccuracy < Accuracy(input, GoranPattern))
            {
                highestAccuracy = Accuracy(input, GoranPattern);
                Name = "Goran";
            }
            Console.WriteLine(highestAccuracy);
            Console.WriteLine(Name);
            input = Console.ReadLine();
        }

        public static int Accuracy(string message, string pattern)
        {
            int accuracyCount = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == pattern[i % pattern.Length]) accuracyCount++;
            }
            return accuracyCount;
        }
    }
}