using System;

namespace dicegame
{
    class Program
    {
        static void Main(string[] args)
        {
            var gunnarLine = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            var emmaLine = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            if(calculateAverage(gunnarLine) < calculateAverage(emmaLine))
            {
                Console.WriteLine("Emma");
            }else if(calculateAverage(gunnarLine) == calculateAverage(emmaLine))
            {
                Console.WriteLine("Tie");
            }else
            {
                Console.WriteLine("Gunnar");
            }

        }

        public static double calculateAverage(int[] arr)
        {
            var firstLower = arr[0];
            var firstUpper = arr[1];
            var secondLower = arr[2];
            var secondUpper = arr[3];

            var avergage = 0.0;

            var sum = 0.0;
            var count = firstUpper - firstLower + 1.0;
            while (firstLower <= firstUpper)
            {
                sum += firstLower;
                firstLower++;
            }

            avergage += sum / count;

            sum = 0;
            count = secondUpper - secondLower + 1.0;
            while (secondLower <= secondUpper)
            {
                sum += secondLower;
                secondLower++;
            }

            avergage += sum / count;

            return avergage;

        }
    }
}
