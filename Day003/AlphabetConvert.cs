using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s;

            String result = "";
            Console.Clear();

            s = Console.ReadLine();
            
            for(int i=0; i<s.Length; i++)
            {
                
                if (char.IsLower(s[i]))
                {
                    result += s.ToUpper()[i];
                    
                }
                else
                {
                    result += s.ToLower()[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
