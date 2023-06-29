using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace stringapp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            //indexof
            Console.WriteLine($"{greeting.IndexOf("Morning")}");
            Console.WriteLine($"{greeting.IndexOf("d")}");
            //lasstIndexOf
            Console.WriteLine($"{greeting.LastIndexOf("Good")}");
            Console.WriteLine($"{greeting.LastIndexOf("o")}");
            //startswith
            Console.WriteLine($"{greeting.StartsWith("Good")}");
            Console.WriteLine($"{greeting.StartsWith("Morning")}");
            //endswith
            Console.WriteLine($"{greeting.EndsWith("Good")}");
            Console.WriteLine($"{greeting.EndsWith("Morning")}");
            //contains
            Console.WriteLine($"{greeting.Contains("Good")}");
            Console.WriteLine($"{greeting.Contains("Morning")}");
            //replace()
            Console.WriteLine($"{greeting.Replace("Morning","Evening")}");
        }
    }
}
