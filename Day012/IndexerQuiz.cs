using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddd
{
    class FrequencyCounter
    {
        private string array;
        public FrequencyCounter(string n)
        {
            array = n;
        }
        //인덱서로 만들고 싶어
        public int this[char index]
        {
            get
            {
                int count = 0;
                for(int i=0; i<array.Length; i++)
                {
                    if (index == array[i])
                        count++;
                }
                return count;
            }
            set
            {
               
            }
        }
        
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FrequencyCounter counter = new FrequencyCounter("hello world");//일반 클래스
            Console.WriteLine(counter['h']);
        }
    }
}
