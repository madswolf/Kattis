using System;
using System.Text;

namespace runlengthencodingrun
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var output = new StringBuilder();

            if (input[0].Equals("E")) 
            {
                char previousCharacter = '*';
                var counter = 1;


                foreach (var character in input[1])
                {
                    if (previousCharacter == character)
                    {
                        counter++;
                    }
                    else
                    {
                        if (previousCharacter != '*')
                        {
                            output.Append(previousCharacter);
                            output.Append(counter);
                            counter = 1;
                        }

                        previousCharacter = character;
                    }
                }
                output.Append(previousCharacter);
                output.Append(counter);
            }
            else
            {

                var word = input[1];
                for (int i = 0; i < word.Length; i += 2)
                {
                    char character = word[i];
                    int number = int.Parse(word[i + 1].ToString());
                    
                    for (int j = 0; j < number; j++)
                    {
                        output.Append(character);
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
