using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"2 + 3 = {AlgorithmSolver.Add(2,3)}");
            Console.WriteLine($"12 - 3 = {AlgorithmSolver.Subtract(12,3)}");
        }
    }
}
