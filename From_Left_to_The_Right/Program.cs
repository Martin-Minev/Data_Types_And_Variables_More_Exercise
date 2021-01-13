using System;
using System.Collections.Generic;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long sumBigerNumber = 0;
            List<long> output = new List<long>();
            for (int i = 0; i < number; i++)
            {
                string line = Console.ReadLine();
                long[] numbers = line.Split().Select(long.Parse).ToArray();
                if (numbers[0] >= numbers[1])
                {
                    if (numbers[0] >= 0)
                    {
                        for (int j = 0; j < numbers[0].ToString().Length; j++)
                        {
                            sumBigerNumber += long.Parse(((numbers[0].ToString())[j]).ToString());
                        }
                        output.Add(sumBigerNumber);
                    }
                    else
                    {
                        for (int j = 1; j < numbers[0].ToString().Length; j++)
                        {
                            sumBigerNumber += long.Parse(((numbers[0].ToString())[j]).ToString());
                        }
                        output.Add(sumBigerNumber);
                    }
                }
                else
                {
                    if (numbers[0] < numbers[1])
                    {
                        if (numbers[1] >= 0)
                        {
                            for (int j = 0; j < numbers[1].ToString().Length; j++)
                            {
                                sumBigerNumber += long.Parse((((numbers[1].ToString())[j]).ToString()));
                            }
                            output.Add(sumBigerNumber);
                        }
                        else
                        {
                            for (int j = 1; j < numbers[1].ToString().Length; j++)
                            {
                                sumBigerNumber += long.Parse((((numbers[1].ToString())[j]).ToString()));
                            }
                            output.Add(sumBigerNumber);
                        }

                    }
                }
                sumBigerNumber = 0;
            }
            foreach (int number1 in output)
            {
                Console.WriteLine(number1);
            }

        }
    }
}
