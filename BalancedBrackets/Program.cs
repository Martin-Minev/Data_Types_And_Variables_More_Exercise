using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            int probe = 0;
            for (int i = 0; i < n; i++)
            {
                string token = Console.ReadLine();
                if (token == "(" || token == ")")
                {
                    input.Add(token);
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "(")
                {
                    if (input[i] == "(" && input[i + 1] == ")" && (i + 1) < input.Count)
                    {
                        probe = 1;
                        i++;
                    }
                }   
                else
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }  
            }
            if (probe == 1)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
