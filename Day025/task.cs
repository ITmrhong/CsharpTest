using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThrdApp
{

    class Program
    {
        static void Main(string[] args)
        {
            // Task 생성자에 Run을 지정 Task 객체 생성
            Task t1 = new Task(new Action(Run));

            // 람다식을 이용 Task객체 생성
            Task t2 = new Task(() =>
            {
                for (char a = 'A'; a <= 'Z'; a++)
                    Console.WriteLine(a);
            });

            // Task 쓰레드 시작
            t1.Start();
            t2.Start();

            // Task가 끝날 때까지 대기
            t1.Wait();
            t2.Wait();
        }

        static void Run()
        {
            int result = 0;
            for(int i=1; i<=100; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
