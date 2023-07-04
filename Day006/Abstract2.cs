using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Hero
    {
        public int level { get; set; }
        public abstract string Attack();
    }
    class Knight : Hero
    {
        public override string Attack()
        {
            return "공격하다";
        }
    }
    class DarkKnight : Knight
    {
    }

    internal class Program
    {
        static void main(string[] args)
        {
            DarkKnight bob = new DarkKnight();
            Console.WriteLine(bob.Attack());
        }
    }
}
