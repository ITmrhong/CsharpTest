using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {
        private String Name;
        public Dog(string _name)
        {
            this.Name = _name;
        }
        public String eat()
        {
            return "먹습니다";
        }
        public String play()
        {
            return "뛰어놀다";
        }
        public String name()
        {
            return Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog tom = new Dog("톰");
            Console.WriteLine("{0}이 음식을 {1}", tom.name(), tom.eat());
           
            Console.WriteLine("{0}이 {1}", tom.name(), tom.play());

        }
    }
}
