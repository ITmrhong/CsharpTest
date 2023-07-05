// See https://aka.ms/new-console-template for more information
using System.Data;
interface WriteLooger
{
    void Writelog(string message); 
}
class ILogger : WriteLooger
{
    public void Writelog(string message)
    {
        Console.WriteLine(DateTime.Now.ToLocalTime() + ":"+message);
    }
}
class Mainclas
{
    public static void Main(string[] args)
    {
        ILogger logger = new ILogger();
        logger.Writelog("이벤트 발생");
    }
}
