using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[3];
            score[0] = 1;
            score[1] = 2;
            score[2] = 3;

            Console.WriteLine(score[0]);
            Console.WriteLine(score[1]);
            Console.WriteLine(score[2]);
            char[] ch = new char[3];
            ch[0] = 'a';
            ch[1] = 'b';
            ch[2] = 'c';
            Console.WriteLine(ch[0]);
            Console.WriteLine(ch[1]);
            Console.WriteLine(ch[2]);
        }
    }
}
