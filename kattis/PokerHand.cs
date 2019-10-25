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
    class PokerHand
    {
        static void bain(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var safetyLimit = int.Parse(line[0]);
            var lineCount = int.Parse(line[1]);
            var peopleCount = 0;
            var groupsRefusedCount = 0;

            for (int i = 0; i < lineCount; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var status = input[0];
                var groupSize = int.Parse(input[1]);
                if (status.Equals("enter"))
                {
                    if (peopleCount + groupSize > safetyLimit)
                    {
                        groupsRefusedCount++;
                    }
                    else
                    {
                        peopleCount += groupSize;
                    }
                }
                else
                {
                    peopleCount -= groupSize;
                }
            }
            Console.WriteLine(groupsRefusedCount);
            Console.ReadLine();
        }

    }
}