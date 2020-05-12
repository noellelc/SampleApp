using System;

namespace SampleApp
{
    public class Calculator
    {
        public int Add(int a, int b) 
        {
            return a + b;
        }

        public int Subtract(int a, int b) 
        {
            return a - b;
        }

        public int Multiply(int a, int b) 
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            return a/b;
        }

        public double Power(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }
}