using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(a.Reverse().ToArray());
        }
    }
}
