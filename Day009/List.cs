using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public Person(string name)
            {
                Name = name;
            }
            static void Main(string[] args)
            {
                Person jaan = new Person("제인");
                Person tom = new Person("톰");
                Person bob = new Person("밥");

                List<Person> list = new List<Person>();
                list.Add(jaan);
                list.Add(tom);
                list.Add(bob);
                //제거
                list.Remove(tom);
                //추가
                Person Sam= new Person("샘");
                list.Add(Sam);

                foreach(Person p in list)
                {
                    Console.WriteLine(p.Name);
                }

            }



        }
    }
}
