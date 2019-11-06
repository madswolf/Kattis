using System;

namespace helpaphd
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                var input = Console.ReadLine();
                if(input.Equals("P=NP")) Console.WriteLine("skipped");
                else
                {
                    var things = Array.ConvertAll(input.Split('+'), s => int.Parse(s));
                    Console.WriteLine(things[0] + things[1]);
                }
            }
        }
    }
}
