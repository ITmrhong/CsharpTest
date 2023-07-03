using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //무한루프 do~wile문만듭니다
            //정수100넣으면 종료되는 프로그램
            int num;
            do
            {
                num=int.Parse(Console.ReadLine());
                switch(num)
                {
                    case 100:
                        break;
                }
                if (num == 100)
                    break;

            } while (true);
        }
    }
}
