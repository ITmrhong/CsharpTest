using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    delegate int MyDelegate(int a, int b);
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Calculator calculator = new Calculator();
            MyDelegate Callback;
            Callback=new MyDelegate(calculator.Plus);//콜백이 더하기 기능이 되었다.
            Console.WriteLine(Callback(5, 10));
            Callback = new MyDelegate(calculator.minus);
            Console.WriteLine(Callback(5, 10));
        }
    }
}
