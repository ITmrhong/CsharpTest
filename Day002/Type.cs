using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;// -128 ~ 127
            byte b = 255; // 0 ~ 255
            Console.WriteLine($"a = {a},b = {b}");
            short c = -32768; // -32768~ +32767
            ushort d = 65535; // 0 ~ 65535
            Console.WriteLine($"c = {c},d = {d}");
            int e = -2147483648; //-2147483648 + 214783647
            uint f = 4294967295; // 0 ~ 4294967295
            Console.WriteLine($"a = {e},b = {f}");
            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            byte i = 240; //240 -> 리터럴;

        }
    }
}
