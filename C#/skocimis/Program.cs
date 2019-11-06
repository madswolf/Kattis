using System;

namespace skocimis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            Console.WriteLine(skip(input[0], input[1], input[2])-1);
        }

        public static int skip(int x, int y, int z)
        {
            if (x + 1 == y && y + 1 == z) return 1;
            if(Math.Abs(x-y) < Math.Abs(y-z))
            {
                return skip(y, z-1, z) + 1;
            }
            else 
            {
                return skip(x, x+1, y) + 1;
            }
        }
    }
}
