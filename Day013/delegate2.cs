using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Myclass
    {
        private delegate void RunDelegate(int i);
        private void RunThis(int val)
        {
            Console.WriteLine(val);

        }
        private void RunThat(int val)
        {
            Console.WriteLine($"{val:X}");
        }
        public void Perform()
        {
            //델리게이트 객체 생성
            RunDelegate run=new RunDelegate(RunThis);
            run(1024);
            run=new RunDelegate(RunThat);
            run(1024);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.Perform();
        }
    }
}
