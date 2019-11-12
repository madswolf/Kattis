using System;
using System.Collections.Generic;
using System.Linq;

namespace mathhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            var leg1 = int.Parse(line[0]);
            var leg2 = int.Parse(line[1]);
            var leg3 = int.Parse(line[2]);
            var legcount = int.Parse(line[3]);
            var result = new List<string>();
            for(int i = 0; i < legcount/leg1 + 1 ; i++)
            {
                for(int j = 0 ; j < legcount/leg2 + 1; j++)
                {
                   for(int v = 0 ; v < legcount/leg3 + 1; v++)
                   {
                        if (i * leg1 + j * leg2 + v * leg3 == legcount)
                        {
                            result.Add(i + " " + j + " " + v);
                        }            
                   } 
                }
            }
            if(result.Any())
            {
                foreach(var permutation in result)
                {
                    Console.WriteLine(permutation);
                }
            }else Console.WriteLine("impossible");
        }
    }
}
