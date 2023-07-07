using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열을 초기화하는 세가지 방법
            string[] array1 = new string[3] {"안녕","Hello","Halo"};
            array1[0] = "안녕";
            array1[1] = "Hello";
            array1[2] = "Halo";
            //배열의 용량을 생략가능
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            string[] array3 = { "안녕", "Hello", "halo" };

            foreach(string s in array1)
            {
                    Console.WriteLine(s);
            }

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };

            Console.WriteLine("type : {0}", arr3.GetType());
            Console.WriteLine("type : {0}", array3.GetType());
        }
    }
}
