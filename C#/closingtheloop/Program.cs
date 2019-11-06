using System;
using System.Collections.Generic;

namespace closingtheloop
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < counter;i++)
            {
                var cases = int.Parse(Console.ReadLine());
                var ropes = Console.ReadLine().Split(' ');

                var redRopes = new List<int>();
                var blueRopes = new List<int>();

                foreach (var rope in ropes)
                {
                    if (rope.Contains('B')) blueRopes.Add(int.Parse(rope.Remove('B')));
                    else blueRopes.Add(int.Parse(rope.Remove('R')));
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
