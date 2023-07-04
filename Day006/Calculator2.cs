using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Calculator
    {
        public int plus(int a, int b)
        {
            return a + b;
        }
        public int plus(int a, int b, int c)
        {
            return a + b + c;
        }
        public double plus(double a, double b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.plus(1.2, 3.3));
            Console.WriteLine(calculator.plus(3,5));
            Console.WriteLine(calculator.plus(1,3,10));
        }
    }
}
