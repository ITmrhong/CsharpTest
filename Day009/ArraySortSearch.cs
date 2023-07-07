using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] q = new int[80];
            int num2;
            for (int i = 0; i < q.Length; i++)

            {
                num2 = r.Next(1, 100); // 1부터 45까지 생성됨
                for (int j = i; j >= 0; j--)
                {
                    if (q[j] == num2)
                    {
                        while (true)
                        {
                            num2 = r.Next(1, 100);
                            if (q[j] != num2)
                                break;
                        }
                    }
                }
                q[i] = num2;
            }
            int cnt = Array.IndexOf(q, 80);
            if (cnt < 0)
            {
                Console.WriteLine("값이 없습니다.");
            }
            else
            {
                Console.WriteLine($"80의 위치 : " + cnt);
                Array.Sort(q);
                cnt = Array.IndexOf(q, 80);
                Console.WriteLine($"정렬 후 80의 위치 : " + cnt);
            }
           
        }

       
    }
}
