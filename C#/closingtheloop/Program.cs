using System;
using System.Collections.Generic;
using System.Text;

namespace closingtheloop
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            var endline = "";
            for(int i = 0; i < counter;i++)
            {
                output.Append(endline);
                var cases = int.Parse(Console.ReadLine());
                var ropes = Console.ReadLine().Split(' ');

                var redRopes = new List<int>();
                var blueRopes = new List<int>();

                foreach (var rope in ropes)
                {

                    if (rope.Contains("B"))
                    {
                        var thing = int.Parse(rope.Replace("B", ""));
                        blueRopes.Add(thing-1);
                    }
                    else
                    {
                        var thing = int.Parse(rope.Replace("R",""));
                        redRopes.Add(thing-1);
                    }
                }
                redRopes.Sort();
                blueRopes.Sort();
                var remainingRed = redRopes.Count-1;
                var remainingBlue = blueRopes.Count - 1;
                var sum = 0;

                while(remainingBlue >= 0 && remainingRed >= 0)
                { 
                    sum += redRopes[remainingRed--] + blueRopes[remainingBlue--];
                }

                endline = "\n";
                output.Append($"Case #{i+1}: {sum}");
            }
            Console.Write(output);
        }
    }
}
