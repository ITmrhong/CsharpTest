using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void CopyArray<T>(T[] src, T[] dst)
        {
            for(int i=0; i<src.Length; i++)
                dst[i] = src[i];
        }
        static void Main(string[] args)
        {
            int[] src = { 1, 2, 3, 4, 5 };
            int[]dst=new int[src.Length];
            CopyArray<int>(src, dst);
            foreach(int i in dst)
                Console.WriteLine(i);
        }
    }
}
