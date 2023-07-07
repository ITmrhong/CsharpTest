using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
       
         
    static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int p = int.Parse(Console.ReadLine());
            stack.Push(p);
            p = int.Parse(Console.ReadLine());
            stack.Push(p);
            p = int.Parse(Console.ReadLine());
            stack.Push(p);

            Console.Write(stack.Pop()+" "+stack.Pop()+" "+stack.Pop() );
        }
       
    }
}
