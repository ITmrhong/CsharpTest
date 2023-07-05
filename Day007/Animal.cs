using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Animal {

        public abstract void Sound(); 
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("냐옹");
        }
    }
    class Tiger : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("어흥");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Dog dog = new Dog();
            Cat cat = new Cat();
            tiger.Sound();
            dog.Sound();
            cat.Sound();
        }
    }
}
