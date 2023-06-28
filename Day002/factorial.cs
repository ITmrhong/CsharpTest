using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forapp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("팩토리얼 입력 : ");
            int i = int.Parse(Console.ReadLine());
            int result=1;
            for(;i >0;i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
       
            
        }
    }
}
