using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp001
{
    class Cat
    {
        
        public Cat()
        {
            Name = "";
            Color = "";
        }
       
        public Cat(string _name, string _color)
        {
            Name = _name;
            Color = _color;
        }
        public string Name;
        public string Color;
        public void Meow()
        {
            Console.WriteLine("{0} : 야옹",this.Name);
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            Console.WriteLine(kitty.Name + kitty.Color);
        }
    }
}
