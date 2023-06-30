using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연속된 메모리 공간에 알파벳 대문자26자를 넣어보세요
            char[] BigAlpha = new char[26];
            //Console.WriteLine(arr.Length);
            char[] SmallAlpha = new char[26];
            char ch = 'Z';
            for(int i=0; i<26; i++)
            {
                BigAlpha[i] = (char)ch--;
                Console.Write(BigAlpha[i]+" ");
            }
            Console.WriteLine();
            ch = 'a';
            for (int i = 0; i < 26; i++)
            {
                SmallAlpha[i] = (char)ch++;
                Console.Write(SmallAlpha[i]+" ");
            }
        }
    }
}
