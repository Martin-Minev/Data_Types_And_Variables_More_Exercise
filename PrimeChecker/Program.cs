using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitRange = int.Parse(Console.ReadLine());
            for (int i = 2; i <= digitRange; i++)
            {
                bool primeDigit = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        primeDigit = false;
                        break;
                    }
                }

                if (primeDigit)
                {
                    Console.WriteLine("{0} -> {1}", i, "true");
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i, "false");
                }
            }

        }
        
    }
}
