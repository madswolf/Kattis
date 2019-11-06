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
    class PizzaCrust
    {
        static void bain(string[] args)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(' '), c => int.Parse(c));

            var pizzaRadius = line[0];
            var crustRadius = line[1];

            var pizzaArea = Math.PI * Math.Pow(pizzaRadius, 2);
            var pizzaAreaWithoutCrust = Math.PI * Math.Pow(pizzaRadius - crustRadius, 2);
            Console.WriteLine((pizzaAreaWithoutCrust / pizzaArea) * 100.0);
            Console.ReadLine();
        }
    }
}