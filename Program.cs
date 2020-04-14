using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();

            Console.WriteLine($"2 + 3 = {calc.Add(2,3)}");
            Console.WriteLine($"12 - 3 = {calc.Subtract(12,3)}");
            Console.WriteLine($"12 * 3 = {calc.Multiply(12,3)}");
            Console.WriteLine($"12 / 3 = {calc.Divide(12,3)}");
        }
    }
}
