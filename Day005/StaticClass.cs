using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Global
    {
        public static int count = 0;
    }
    class ClassA
    {
        public ClassA()
        {
            Global.count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global Count : {Global.count}");
            ClassA a = new ClassA();
            ClassA a1 = new ClassA();
            ClassA a2 = new ClassA();
            ClassA a3 = new ClassA();
            Console.WriteLine($"Global Count : {Global.count}");
            ClassB b = new ClassB();
            Console.WriteLine($"Global Count : {Global.count}");
        }
    }
}
