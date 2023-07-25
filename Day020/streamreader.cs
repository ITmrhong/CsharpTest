using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MemoryStream 
            MemoryStream ms = new MemoryStream();
            byte[] strBytes = {1,2,3,4,5};
            ms.Write(strBytes, 0, strBytes.Length);
            ms.Position = 0; //함정
            byte[] buffer = new byte[5];
            ms.Read(buffer, 0, buffer.Length);
            foreach(byte b in buffer)
            {
                Console.WriteLine(b);
            }
          }
    }
}
