using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class ReverseBinaryNumber
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var binary = Convert.ToString(int.Parse(input),2).ToArray(); 
            Array.Reverse(binary); 
            Console.WriteLine(Convert.ToInt32(new String(binary),2));
        }
    }
}
