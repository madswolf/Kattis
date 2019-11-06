using System;
using System.Collections.Generic;
using System.Text;

namespace mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine().Trim());

            for(int i = 0; i < input; i++)
            {
                var arr = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var rows = int.Parse(arr[0]);

                var lines = new List<string>();

                for(int j = 0; j < rows; j++)
                {
                    var line = Console.ReadLine();
                    var reverseLine = new StringBuilder();
                 
                    for (int v = line.Length-1; v >= 0; v--)
                    {
                        reverseLine.Append(line[v]);
                    }
                    lines.Add(reverseLine.ToString());
                }
                var reverseLines = lines.ToArray();
                Array.Reverse(reverseLines);

                var output = new StringBuilder($"Test {i + 1}\n");
                foreach(var line in reverseLines)
                {
                    output.Append(line + "\n");
                }

                Console.WriteLine(output);
            }
        }

    }
}
