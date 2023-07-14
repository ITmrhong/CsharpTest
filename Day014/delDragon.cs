using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    internal class Program
    {
        delegate void Dragon(string name);
        static void Fly(string name)
        {
            Console.WriteLine("{0}이 하늘을 날고 있습니다", name);
        }
        static void Bress(string name)
        {
            Console.WriteLine("{0}이 브레스를 내뿜습니다!",name);
        }
        static void Die(string name)
        {
            Console.WriteLine("{0}이 죽었습니다 R.I.P",name);
        }
        static void Main(string[] args)
            
        {
            Dragon dragon = new Dragon(Fly);
            dragon += new Dragon(Bress);
            dragon += new Dragon(Die);


            dragon("푸른눈의 백룡");


        }
    }
}
