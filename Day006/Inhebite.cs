using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOApp005
{
    //상속
    class Car
    {
        public string name;
        protected int speed;
        private string brand;
        public void run()
        {
            Console.WriteLine("차가 달리다");
        }

    }
    class SuperCar : Car
    {
        public SuperCar()
        {
            this.speed = 0;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperCar sc = new SuperCar();
            sc.run();
            sc.name = "자동차";
        }
    }
}
