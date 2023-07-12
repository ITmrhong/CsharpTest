using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddd
{
    class Mylist
    {
        private int[] array;
        public Mylist()
        {
            array = new int[3];
        }
        //인덱서로 만들고 싶어
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }
                array[index] = value;

            }
        }
            public int Length { get { return array.Length; } }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mylist list = new Mylist();//일반 클래스
            for(int i =0;i<5;i++)
            {
                list[i] = i;
            }
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
            
        }
    }
}
