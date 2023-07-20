using Oracle.ManagedDataAccess.Client;
using System;
using System.ComponentModel.Design;

namespace OracleApp_insert2
{
    internal class Program
    {
        static string Createtable()
        {
            string input;
            string result;
            Console.Write("나라 입력 : ");
            input = Console.ReadLine();
            result = "CREATE TABLE " + input +
                     "(ID number(4) PRIMARY KEY,  " +
                      "LINE varchar2(20), " +
                      "NAME varchar2(20), AGE NUMBER(4), HEIGHT NUMBER(4)," +
                      "WEIGHT NUMBER(4), MONEY NUMBER(20), REGION varchar2(20))";
            Console.WriteLine($"{input}나라 테이블이 생성되었습니다!");
            return result;
        }
        static string Droptable()
        {
            string input;
            string result;
            Console.Write("삭제할 나라 입력 : ");
            input = Console.ReadLine();
            result = "DROP TABLE " + input;
            return result;
        }
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
                Console.WriteLine("1. 축구 국가대표 테이블 생성");
                Console.WriteLine("2. 국가대표 테이블 삭제 ");
                Console.WriteLine("3. 국가대표 테이블 접속");
                Console.WriteLine("4. 프로그램 종료");
                

                Console.Write("입력 : ");
                n = int.Parse(Console.ReadLine());
                int n2;
                string input, input2;
                string country;

                if (n == 1)//테이블 생성
                {
                    cmd.CommandText = Createtable();
                    cmd.ExecuteNonQuery();
                }
                else if (n == 2)
                {
                    cmd.CommandText = Droptable();
                    cmd.ExecuteNonQuery();
                }

                else if (n == 3)//테이블 접속 
                {
                    
                        Console.Write("접속할 나라의 이름을 적어주세요 : ");
                        input = Console.ReadLine();
                    Console.Clear();
                    country = input;
                    while (true)
                    {
                       
                        
                        Console.WriteLine($"{country}나라의 테이블입니다. 선수 생성,선수 방출,선수 데이터 변경 모두 가능합니다.");
                        Console.WriteLine("1. 선수 생성 ");
                        Console.WriteLine("2. 선수 방출 ");
                        Console.WriteLine("3. 전체 선수 조회");
                        Console.WriteLine("4. 선수 데이터 변경 ");
                        Console.WriteLine("5. 처음 화면으로 돌아가기");
                        n = int.Parse(Console.ReadLine());

                        if (n == 1)
                        {
                            cmd.CommandText = "INSERT INTO " +country+" VALUES(";
                            Console.Write("선수 등번호를 입력하세요 : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + ",\'";
                            Console.Write("포지션을 입력하세요 : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + "\',\'";
                            Console.Write("선수 이름을 입력하세요 : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + "\',";
                            Console.Write("선수 나이를 입력하세요 : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + ",";
                            Console.Write("선수 키를 입력하세요 : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + ",";
                            Console.Write("선수 몸무게를 입력하세요 : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + ",";
                            Console.Write("선수 연봉을 입력하세요(단위:원) : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + ",\'";
                            Console.Write("선수 국적을 입력하세요(단위:원) : ");
                            input = Console.ReadLine();
                            cmd.CommandText += input + "\')";
                            Console.WriteLine(cmd.CommandText);
                            cmd.ExecuteNonQuery();
                        }

                        if(n==2)
                        {
                            Console.Write("방출할 선수의 이름을 입력하세요 :");
                            input = Console.ReadLine();
                            cmd.CommandText = "DELETE FROM " + country + " WHERE NAME= " + input;
                            Console.WriteLine("삭제가 완료되었습니다");
                        }
                        if(n==3)
                        {
                            Console.WriteLine("--------------------------------");
                            cmd.CommandText = "SELECT * FROM "+country +" ORDER BY ID ASC";
                            OracleDataReader rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {

                                int id = int.Parse(rdr["ID"].ToString());
                                string line = rdr["LINE"] as string;
                                string name = rdr["NAME"] as string;
                                int age = int.Parse(rdr["AGE"].ToString());
                                int height = int.Parse(rdr["HEIGHT"].ToString());
                                int weight = int.Parse(rdr["WEIGHT"].ToString());
                                int money = int.Parse(rdr["MONEY"].ToString());
                                string region = rdr["REGION"] as string;


                                Console.WriteLine($"등번호 : {id} 포지션 : {line} 나이: {age} " +
                                    $"이름 : {name} 키 : {height} 몸무게 : {weight} 연봉 : {money} 국적 : {region}");
                            }
                            Console.WriteLine("--------------------------------");
                        }
                        if(n==4)
                        {
                            cmd.CommandText = "UPDATE " + country + " SET ";
                            Console.WriteLine("수정할 선수의 이름을 입력하세요 : ");
                            input2 = Console.ReadLine();
                            Console.Write("무엇을 수정할건지 입력하세요 \n1.등번호 2.포지션 3.나이" +
                                "4.키 5.몸무게 6.연봉 7. 국적 : ");
                            n = int.Parse(Console.ReadLine());
                            Console.Write("수정할 값을 입력하세요 그대로면 그대로 쓰셔도 됩니다. : ");
                            input = Console.ReadLine();
                            if (n == 1)
                                cmd.CommandText += "ID = " + input +" ";
                            if (n == 2)
                                cmd.CommandText += "LINE = \'" + input+"\' ";
                            if (n == 3)
                                cmd.CommandText += "NAME = \'" + input + "\' ";
                            if (n == 4)
                                cmd.CommandText += "AGE = " + input + " ";
                            if (n == 5)
                                cmd.CommandText += "WEIGHT = " + input + " ";
                            if (n == 6)
                                cmd.CommandText += "MONEY = " + input + " ";
                            if (n == 7)
                                cmd.CommandText += "REGION = \'" + input + "\' ";
                            cmd.CommandText += "WHERE NAME = \'" + input2 +"\'";
                            Console.WriteLine(cmd.CommandText);
                            cmd.ExecuteNonQuery();
                            
                            Console.WriteLine("수정이 완료되었습니다!");




                        }
                        if(n==5)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }

              
               

               
                else if(n==4)
                {
                    break;

                }
            }
                

                
            
           conn.Close();
            

        }
    }
}
