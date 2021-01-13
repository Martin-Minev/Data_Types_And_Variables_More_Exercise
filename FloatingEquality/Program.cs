using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equality = Math.Abs(a - b) < eps;
            Console.WriteLine(equality);
        }
    }
}
