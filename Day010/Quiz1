using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacApp01
{
    //유니콘 -> 말 , 천사이ㅡ 날개
    interface iWeapon
    {
        void Weapon();
    }
    interface iBow
    {
        void bow();
    }
    class Knight : iWeapon, iBow
    {
      
        public string Name { get; set; }
        public Knight(string name)
        {
            Name = name;
            
        }
        public void bow()
        {
            Console.Write("활을 ");
        }

        public void Weapon()
        {
            Console.Write("쏩니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight 승현 = new Knight("아더");
            Console.WriteLine(승현.Name + "가 " );
            승현.bow();
            승현.Weapon();
        }
    }
}
