using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
        class Myclass
    {
        private string input;
        public Myclass(string input)
        {
            this.input = input;
        }

        public int CharCounter(string arr, char word)
        {
            int count = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] == word)
                {
                    count++;
                }
            }
            return count;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열 : ");
            string input = Console.ReadLine();
            Myclass myclass = new Myclass(input);
            Console.Write("문자 : ");
            char word = char.Parse(Console.ReadLine());
            Console.WriteLine("결과 : "+myclass.CharCounter(input,word));
        }
    }
}
