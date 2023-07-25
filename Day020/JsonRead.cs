using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text ;
using System.Text.Json;
using System.Threading.Tasks;

namespace IOTest
{
    class Student
    {
        public int STID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "a.json";
            using (Stream ws = new FileStream(fileName, FileMode.Create))
            {
                Student nc = new Student();
                nc.Name = "홍길동";
                nc.STID = 20181100;
                nc.Major = "정보통신공학과";
                
                string jsonString = JsonSerializer.Serialize<Student>(nc);//객체 직렬화
                Console.WriteLine(jsonString);
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes,0, jsonBytes.Length);//a.json 파일 만들기 객체 직렬화해서 파일에 넣기
     
                //친구 컴퓨터로 전송~~!! NetWork Programming
            }
            
            using(Stream rs = new FileStream(fileName, FileMode.Open))
            {
                byte[] jsonBytes = new byte[rs.Length];
                rs.Read(jsonBytes,0,jsonBytes.Length);
                string jsonString = Encoding.UTF8.GetString(jsonBytes);
                Student nc2=JsonSerializer.Deserialize<Student>(jsonString);

                Console.Write("학번 : ");
                Console.WriteLine(nc2.STID);
                Console.Write("이름 : ");
                Console.WriteLine(nc2.Name);
                Console.Write("전공 : ");
                Console.WriteLine(nc2.Major);
            }
            
        }
    }
}
