using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                bool integerCheck = int.TryParse(input, out int integer);
                bool doubleCheck = double.TryParse(input, out double floating);
                bool charCheck = char.TryParse(input, out char mychar);
                bool boolCheck = bool.TryParse(input, out bool boolean);

                if (integerCheck)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (doubleCheck)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (charCheck)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (boolCheck)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }

        }
    }
}
