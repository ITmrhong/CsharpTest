using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace CakeOrderSystem
{
    public class Cake
    {
        public string Name { get; set; }
    }
    public class Chef
    {
        
        // 케익을 만드는 메서드를 추가하세요. 이 메서드는 케익을 만드는 데 1초가 걸립니다.
        private object _lock = new object();
        public Cake BakeCake(string name)
        {
                lock( _lock )
                {
                Console.WriteLine($"주방장이 {name}을 만들기 시작하였습니다.");
                    Thread.Sleep(1000);
                Console.WriteLine(name + "가 완성되었습니다!");
            }
                
            
            return new Cake { Name = name};
        }
    }

    public class Customer

    {
        // 케익 주문 메서드를 추가하세요. 주문이 들어오면 Chef가 케익을 만들기 시작하고, 케익이 완성되면 케익을 받습니다.
        public void OrderCake(Chef chef, string name)
        {
            //여기에 코딩하세요.
            Console.WriteLine($"손님이 {name} 케익을 주문했습니다.");
            chef.BakeCake(name);
            
            Console.WriteLine($"손님이 {name}케익을 받았습니다. ");
            

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Chef chef = new Chef();
            Customer customer = new Customer();
            Thread Guest1 = new Thread(() => customer.OrderCake(chef, "딸기"));
            Thread Guest2 = new Thread(() => customer.OrderCake(chef, "바나나"));
            Thread Guest3 = new Thread(() => customer.OrderCake(chef, "초코"));
            Thread Guest4 = new Thread(() => customer.OrderCake(chef, "치즈"));
            Thread Guest5 = new Thread(() => customer.OrderCake(chef, "토마토"));

            Guest1.Start();
            Guest2.Start();
            Guest3.Start();
            Guest4.Start();
            Guest5.Start();

            Guest1.Join();
            Guest2.Join();
            Guest3.Join();
            Guest4.Join();
            Guest5.Join();
            // 여기에서 주문과 케익 제작 프로세스를 코딩하세요.
        }

    }

}
