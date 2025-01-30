using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine($"Sum numbers {a} and {b} =: {sum}");
        }
    }
}
