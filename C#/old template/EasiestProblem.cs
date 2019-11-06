using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class EasiestProblem
    {
        static void bain(string[] args)
        {
            string input = Console.ReadLine();
            while (!input.Equals("0"))
            {
                var inputNumber = int.Parse(input);
                var sumOfDigits = SumOfDigits(inputNumber);

                for (int i = 11; i < 100000; i++)
                {
                    if (SumOfDigits(inputNumber * i) == sumOfDigits)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                input = Console.ReadLine();
            }
        }

        public static int SumOfDigits(int input)
        {
            var output = 0;
            int[] digits = Array.ConvertAll(input.ToString().ToCharArray(), c => (int)Char.GetNumericValue(c));

            foreach (int digit in digits)
            {
                output += digit;
            }
            return output;
        }
    }
}