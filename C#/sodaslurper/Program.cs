using System;

namespace sodaslurper
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            var empty = input[0] + input[1];
            var c = input[2];

            var sum = 0;
            while (empty >= c)
            {
                empty -= c;
                empty++;
                sum++;
            }
            Console.WriteLine(sum);
        }
    }
}
