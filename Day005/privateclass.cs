using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Global
    {
        public static int count = 0;
    }
    class Tiger
    {
        private string name;
        private int age;

        public void setage(int age)
        {
            this.age = age;
        }
        public int getage()
        {
            return this.age;
        }
        public Tiger(string _name)
        {
            name = _name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          Tiger timon = new Tiger("티몬");
          timon.setage(5);
            Console.WriteLine(timon.getage()+"살");
            
        }
    }
}
