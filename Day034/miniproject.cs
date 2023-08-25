using Microsoft.EntityFrameworkCore;
using System;

namespace LinqSample_001
{
    public class  StudentScore
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string KOR { get; set; }
        public string MATH { get; set; }
        public string ENG { get; set; }
    }
    public class PersonContext : DbContext
    {
        public DbSet<StudentScore> StudentScore { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=c##scott;Password=tiger;Data Source=127.0.0.1/XE;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentScore>()   //Primary key 지정
                .HasKey(p => p.ID);

            modelBuilder.Entity<StudentScore>()   //Varchar2(30) 30크기를 정할 때
                .Property(p => p.NAME)
                .HasMaxLength(20);

            modelBuilder.Entity<StudentScore>()
                .Property(p => p.KOR)
                .HasMaxLength(4);
        modelBuilder.Entity<StudentScore>()
                .Property(p => p.MATH)
                .HasMaxLength(4);
            modelBuilder.Entity<StudentScore>()
                .Property(p => p.ENG)
                .HasMaxLength(4);
        }
    }

    internal class Program
    {
        static string score(int num)
        {
            string result;
            if (num >= 95)
                result = "A+";
            else if (num >=90)
                result = "A";
            else if (num >= 85)
                result = "B+";
            else if (num >= 80)
                result = "B";
            else if (num >= 75)
                result = "C";
            else if (num >= 70)
                result = "D";
            else
                result = "F";
            return result;
        }
        static void Main(string[] args)
        {
            int input;
            using (var context = new PersonContext())
            {
                context.Database.EnsureCreated();
                while (true)
                {
                    Console.WriteLine(
                        "quu..__\r\n $$$b  `---.__\r\n  \"$$b        `--.                          ___.---uuudP\r\n   `$$b           `.__.------.__     __.---'      $$$$\"              .\r\n     \"$b          -'            `-.-'            $$$\"              .'|\r\n       \".                                       d$\"             _.'  |\r\n         `.   /                              ...\"             .'     |\r\n           `./                           ..::-'            _.'       |\r\n            /                         .:::-'            .-'         .'\r\n           :                          ::''\\          _.'            |\r\n          .' .-.             .-.           `.      .'               |\r\n          : /'$$|           .@\"$\\           `.   .'              _.-'\r\n         .'|$u$$|          |$$,$$|           |  &lt;            _.-'\r\n         | `:$$:'          :$$$$$:           `.  `.       .-'\r\n         :                  `\"--'             |    `-.     \\\r\n        :##.       ==             .###.       `.      `.    `\\\r\n        |##:                      :###:        |        &gt;     &gt;\r\n        |#'     `..'`..'          `###'        x:      /     /\r\n         \\                                   xXX|     /    ./\r\n          \\                                xXXX'|    /   ./\r\n          /`-.                                  `.  /   /\r\n         :    `-  ...........,                   | /  .'\r\n         |         ``:::::::'       .            |&lt;    `.\r\n         |             ```          |           x| \\ `.:``.\r\n         |                         .'    /'   xXX|  `:`M`M':.\r\n         |    |                    ;    /:' xXXX'|  -'MMMMM:'\r\n         `.  .'                   :    /:'       |-'MMMM.-'\r\n          |  |                   .'   /'        .'MMM.-'\r\n          `'`'                   :  ,'          |MMM&lt;\r\n            |                     `'            |tbap\\\r\n             \\                                  :MM.-'\r\n              \\                 |              .''\r\n               \\.               `.            /\r\n                /     .:::::::.. :           /\r\n               |     .:::::::::::`.         /\r\n               |   .:::------------\\       /\r\n              /   .''               &gt;::'  /\r\n              `',:                 :    .'\r\n                                   `:.:'\r\n"
                        );
                    Console.WriteLine("-------------------------------------------\n"+
                        "1. 학생 점수 삽입\n" +
                        "2. 학생 점수 수정\n" +
                        "3. 학생 데이터 삭제\n" +
                        "4. 모든 학생 성적 조회\n" +
                        "5. 프로그램 종료\n"+"-------------------------------------------\n");
                    Console.Write("안녕하세요 성적관리시스템입니다. 메뉴를 숫자로 입력해주세요 : ");
                    input=int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (input == 1)
                    {
                        int id;
                        string name, kor, math, eng;
                        Console.Write("학생의 학번을 입력해주세요 : ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("학생의 이름을 입력해주세요 : ");
                        name = Console.ReadLine();
                        Console.Write("학생의 국어 점수를 입력해주세요 : ");
                        kor = score(int.Parse(Console.ReadLine()));
                        Console.Write("학생의 수학 점수를 입력해주세요 : ");
                        math = score(int.Parse(Console.ReadLine()));
                        Console.Write("학생의 영어 점수를 입력해주세요 : ");
                        eng = score(int.Parse(Console.ReadLine()));
                        var student = new List<StudentScore>
                        {
                            new StudentScore {ID=id,NAME=name,KOR=kor,MATH=math,ENG=eng }
                        };
                        context.StudentScore.AddRange(student);
                        context.SaveChanges();
                        Console.WriteLine("데이터 삽입 성공! 아무키나 누르면 넘어갑니다....");
                        Console.ReadKey(true);
                        Console.Clear();
                    }

                    else if (input == 2)
                    {
                        Console.Write("수정할 데이터 학생의 이름을 입력해주세요 : ");
                        string idinput = Console.ReadLine();
                        var personToEdit = context.StudentScore.FirstOrDefault(p => p.NAME == idinput);

                        // 해당 레코드가 존재하면 수정하기
                        if (personToEdit != null)
                        {
                            Console.Write("1.이름 2.국어 3.수학 4.영어 중에 무엇을 수정할 건지 입력해주세요 : ");
                            int i = int.Parse(Console.ReadLine());
                            if(i==1)
                            {
                                Console.Write("변경할 이름을 입력해주세요 : ");
                                personToEdit.NAME = Console.ReadLine();
                            }
                            else if (i==2)
                            {
                                Console.Write("점수를 입력해주세요 (숫자로) : ");
                                personToEdit.KOR = score(int.Parse(Console.ReadLine()));
                            }
                            else if (i == 3)
                            {
                                Console.Write("점수를 입력해주세요 (숫자로) : "  );
                                personToEdit.MATH = score(int.Parse(Console.ReadLine()));
                            }
                            else if (i == 4)
                            {
                                Console.Write("점수를 입력해주세요 (숫자로) : ");
                                personToEdit.ENG = score(int.Parse(Console.ReadLine()));
                            }
                            

                            // 변경 사항 저장
                            context.SaveChanges();
                            Console.WriteLine("데이터 수정 성공!");
                           
                        }
                        else
                        {
                            Console.WriteLine($"{idinput} 데이터를 찾을 수 없습니다.");
                        }
                        Console.WriteLine("아무키나 누르면 넘어갑니다....");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    else if (input == 3)
                    {
                        Console.Write("삭제할 학생의 이름을 입력해주세요 : ");
                        string idinput = Console.ReadLine();
                        var personToDelete = context.StudentScore.FirstOrDefault(p => p.NAME == idinput);

                        // 해당 레코드가 존재하면 삭제하기
                        if (personToDelete != null)
                        {
                            context.StudentScore.Remove(personToDelete);

                            // 변경 사항 저장
                            context.SaveChanges();
                            Console.WriteLine($"{idinput} 데이터 삭제 성공!");
                        }
                        else
                        {
                            Console.WriteLine($"{idinput} 데이터를 찾을 수 없습니다.");
                        }
                        Console.WriteLine("아무키나 누르면 넘어갑니다....");
                        Console.ReadKey(true);
                        Console.Clear();

                    }

                    else if (input == 4)
                    {
                        var persons = context.StudentScore.ToList();

                        // 헤더 출력
                        Console.WriteLine($"{nameof(StudentScore.ID),-15} {nameof(StudentScore.NAME),-10} {nameof(StudentScore.KOR),-5} {nameof(StudentScore.MATH),-5}" +
                            $" {nameof(StudentScore.ENG),-5}");
                        Console.WriteLine(new string('-', 45));
                        /* nameof 연산자는 C# 6.0에서 도입된 연산자로, 변수, 타입, 또는 멤버의 이름을 문자열로 반환
                           주로 예외 메시지나 로깅, 속성명 변경 알림 등에서 사용 */

                        // 데이터 출력
                        foreach (var p in persons)
                        {
                            Console.WriteLine($"{p.ID,-15} {p.NAME,-10} {p.KOR,-5} {p.MATH,-5} {p.ENG,-5}");
                        }
                        Console.WriteLine("아무키나 누르면 넘어갑니다....");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                    else if (input == 5)
                    {
                        break;
                    }
                    else
                        Console.WriteLine("잘못된 수를 입력하셨습니다! 다시 입력해주세요!");
                    // 해당 레코드가 존재하면 수정하기
                }
                
            }
        }
    }
}
