using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle p = new Triangle();
            p.Draw();
            Shape s = new Triangle();
            s.Draw();
        }
    }
}
