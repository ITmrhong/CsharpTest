using Oracle.ManagedDataAccess.Client;
using System;
using System.ComponentModel.Design;

namespace OracleApp_insert2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SELECT 데이터 조회
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

            //1.연결 객체 만들기 - Client
            OracleConnection conn = new OracleConnection(strConn);
            
            //2.데이터베이스 접속을 위한 연결
            conn.Open();

            //명령객체 생성
            OracleCommand cmd = new OracleCommand();
            
            cmd.Connection = conn;
            int n;
            //데이터 조회
            while (true)
            {
                Console.WriteLine("1. 테이블 생성");
                Console.WriteLine("2. 테이블 삭제");
                Console.WriteLine("3. 데이터 삽입");
                Console.WriteLine("4. 데이터 삭제");
                Console.WriteLine("5. 데이터 수정");
                Console.WriteLine("6. 데이터 조회");
                Console.WriteLine("7. 프로그램 종료");

                Console.Write("입력 : ");
                n = int.Parse(Console.ReadLine());
                int n2;
                string input,input2;

                if (n == 1)//테이블 생성
                {
                    cmd.CommandText = "CREATE TABLE ADDRESSBOOK " +
                     "(ID number(4) PRIMARY KEY,  " +
                      "NAME varchar(20), " +
                      "HP varchar(20))";
                    cmd.ExecuteNonQuery();
                }
                else if (n == 2)
                {
                    cmd.CommandText = "DROP TABLE ADDRESSBOOK";
                    cmd.ExecuteNonQuery();
                }

                else if (n == 3)//데이터 삽입
                {
                    cmd.CommandText = "INSERT INTO ADDRESSBOOK(ID,NAME,HP) VALUES(";
                    Console.Write("ID를 입력하세요 : ");
                    input = Console.ReadLine();
                    cmd.CommandText += input + ",\'";
                    Console.Write("이름을 입력하세요 : ");
                    input = Console.ReadLine();
                    cmd.CommandText += input + "\',\'";
                    Console.Write("핸드폰 번호를 입력하세요 : ");
                    input = Console.ReadLine();
                    cmd.CommandText += input + "\')";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }

                else if (n == 4)//데이터 삭제
                {
                    cmd.CommandText = "DELETE FROM ADDRESSBOOK WHERE ID =";
                    Console.Write("삭제할 본인의 ID을  입력하세요 : ");
                    input = Console.ReadLine();
                    cmd.CommandText += input;
                    Console.WriteLine("삭제되었습니다");
                    
                    cmd.ExecuteNonQuery();
                }

                else if (n == 5)//데이터 수정
                {
                    cmd.CommandText = "UPDATE ADDRESSBOOK SET ";
                    Console.Write("변경할 본인의 ID을  입력하세요 : ");
                    input = Console.ReadLine();
                    Console.Write("이름을 변경할건지 HP를 변경할건지 숫자로 쓰시오 1.이름 2.HP : ");
                    n2 = int.Parse(Console.ReadLine());
                    if(n2==1)
                    {
                        Console.Write("변경할 이름을 입력하세요 : ");
                        input2 = Console.ReadLine();
                        cmd.CommandText += "NAME = \'" + input2 + "\' ";
                    }

                    if (n2 == 2)
                    {
                        Console.Write("변경할 HP을 입력하세요 : ");
                        input2 = Console.ReadLine();
                        cmd.CommandText += "HP = \'" + input2 + "\' ";
                    }


                    cmd.CommandText += "WHERE ID = "+input;
                    Console.WriteLine(cmd.CommandText);

                    cmd.ExecuteNonQuery();
                }

                else if (n == 6)//데이터 조회
                {
                    
                    Console.WriteLine("--------------------------------");
                    cmd.CommandText = "SELECT ID,NAME,HP FROM ADDRESSBOOK ORDER BY ID";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                       
                        int id = int.Parse(rdr["ID"].ToString());
                        string name = rdr["NAME"] as string;
                        string hp = rdr["HP"] as string;
                        

                        Console.WriteLine($"ID : {id} NAME : {name} HP : {hp}");
                    }
                    Console.WriteLine("--------------------------------");
                }
                else if(n==7)
                {
                    break;

                }
            }
                

                
            
           conn.Close();
            

        }
    }
}
