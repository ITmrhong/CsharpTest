using System;

using System.Collections.Generic;

using System.Globalization;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Dog

{

    class Calculator

    {

        private int kor, eng, math, total = 0;

        private double avg;

        public Calculator(int _kor,int _eng,int math_)

        {

            this.kor = _kor;

            this.eng = _eng;

            this.math = math_;

        }

        public void executeTotalScore()

        {

            total += kor + eng + math;

            Console.WriteLine("총점 : " + total);

        }

        public void excuteAvg()

        {

            avg = total / (double)3;

            Console.WriteLine("평균 : " + avg);

        }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.Write("국어 : ");

            int kor=int.Parse(Console.ReadLine());

            Console.Write("영어 : ");

            int eng=int.Parse(Console.ReadLine());

            Console.Write("수학 : ");

            int math = int.Parse(Console.ReadLine());

            Calculator a = new Calculator(kor,eng,math);

            a.executeTotalScore();

            a.excuteAvg();



        }

    }

}
