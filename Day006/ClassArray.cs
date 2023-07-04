using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp007
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다.");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다.");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다.");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그리다.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Draw();
            Triangle triangle = new Triangle();
            triangle.Draw();
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            Circle circle = new Circle();
            circle.Draw();

            Shape[] shapes = new Shape[4];
                shapes[0] = new Shape();
            shapes[1] = new Triangle();
            shapes[2] = new Rectangle();
            shapes[3] = new Circle();

            for(int i=0;i<4; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}
