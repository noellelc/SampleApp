using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (int i in Power(2, 8))
            {
                Console.WriteLine($"{i} ");
            }

            Calculator calc = new Calculator();

            Console.WriteLine($"2 + 3 = {calc.Add(2,3)}");
            Console.WriteLine($"12 - 3 = {calc.Subtract(12,3)}");
            Console.WriteLine($"12 * 3 = {calc.Multiply(12,3)}");
            Console.WriteLine($"12 / 3 = {calc.Divide(12,3)}");
        }

        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i ++)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
