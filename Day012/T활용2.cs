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
        class MyList<T>
        {
            private T[] array;
            public MyList()
            {
                array = new T[3];
            }
            public T this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    array[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
