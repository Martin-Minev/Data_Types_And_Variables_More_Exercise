using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[] output = new char[n];

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int inputValue = (int)input;
                int outputValue = inputValue + key;
                output[i] = (char)outputValue;

            }
            Console.Write(string.Join("",output));
        }
    }
}
