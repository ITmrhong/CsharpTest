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
        delegate void ThereisAsFire(string location);
        public static void Call119(string location)
        {
            Console.WriteLine("소방서죠? 불났어요? 주소는 {0}", location);
        }
        public static void ShoutOut(string location) 
        {
            Console.WriteLine("피하세요! {0}에 불이났어요.", location);
        }
        public static void Escape(string location)
        {
            Console.WriteLine("{0}에서 나가세요.", location);
        }
        static void Main(string[] args)
        {
            ThereisAsFire fire = new ThereisAsFire(Call119);
            fire += new ThereisAsFire(ShoutOut);
            fire += new ThereisAsFire(Escape);

            fire("우리집");
        }
    }
}
