using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 1)
                    Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
            for(int i=0;i<arr.Length ;i++)
            {
                if (arr[i] % 3 == 0)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
