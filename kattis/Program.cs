using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kattis
{
    class DetailedDifferences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            

            while (input != null)
            {
                int count = int.Parse(input);
                var output = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    var string1 = Console.ReadLine();
                    var string2 = Console.ReadLine();
                    
                    output.Append(string1 + "\n");
                    output.Append(string2 + "\n");

                    var string1AsChars = string1.ToCharArray();
                    var string2AsChars = string2.ToCharArray();
                    var differences = new char[string1.Length];

                    for (int j = 0; j < string1.Length; j++)
                    {
                        if (string1AsChars[j] == string2AsChars[j])
                        {
                            differences[j] = '.';
                        }
                        else
                        {
                            differences[j] = '*';
                        }
                    }

                    output.Append(new String(differences) + "\n" + "\n");
                }

                Console.Write(output.ToString());
                input = Console.ReadLine();
            }
        }

     
    }
}
