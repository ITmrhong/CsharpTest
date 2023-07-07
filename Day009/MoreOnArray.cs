SELECT 과목이름, MIN(점수) AS 최소점수 MAX(점수) AS 최대점수 FROM 성적
GROUP BY 과목이름 HAVING AVG(점수)>=90;


SELECT 부서,SUM(급여) AS 급여합계 FROM 급여 GROUP 
BY 부서 HAVING 급여합계>=6000;

SELECT 학과,COUNT()



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
        private static void Print (int value)
        {
            Console.Write($"{value} ");
        }
        private static bool CheckPassed(int score)
        {
            return score > 62;
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34};
            int[,] s2 = new int[0,0];
            //1.정렬
            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));

            //2,Rank 배열의 차원을 반환

            Console.WriteLine("\n"+scores.Rank+"차원 배열");
            Console.WriteLine(s2.Rank + "차원 배열");

            //3.찾기
            Console.WriteLine($"이진탐색 81 : " + Array.BinarySearch<int>(scores, 34));
            //4.선형찾기 Linear Search
            Console.WriteLine($"선형탐색 90 : " + Array.IndexOf(scores, 80));

            //5.조건검사
            Console.WriteLine(Array.TrueForAll<int>(scores, CheckPassed));
            int index = Array.FindIndex<int>(scores, (score) => score >= 60);
            Console.WriteLine("index : " + index);

            //6.배열 크기 재조정
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine("변경된 배열의 길이 : " + scores.Length);

            //7.배열 요소 초기화
            Array.ForEach<int>(scores, new Action<int>(Print));
            Array.Clear(scores,3,7);
            Console.WriteLine();
            Array.ForEach<int>(scores, new Action<int>(Print));

            //8.배열 자르기 
            int[] sliced = new int[3];
            Array.Copy(scores,0,sliced,0,3);
            Array.ForEach<int>(sliced, new Action<int>(Print));

        }

       
    }
}
