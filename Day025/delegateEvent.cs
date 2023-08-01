using System;
namespace EventQuiz
{
    public delegate void DataReceivedEventHandler(object sender, EventArgs e);
    public class DataReceiver
    {
        // DataReceivedEventHandler 타입의 이벤트를 여기에 구현하세요.
        public event DataReceivedEventHandler DataReceived;//이벤트로 만든다.
        public void OnDataReceived()
        {
            DataReceived?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            DataReceiver receiver = new DataReceiver();
            // 이곳에 콘솔출력 람다식을 만드세요.
            receiver.DataReceived += (sender, e) =>
            {
                Console.WriteLine("데이터를 받았습니다!");
            };
            //
            receiver.OnDataReceived();  // 이 메서드 호출을 통해 이벤트를 트리거하세요

        }
    }
}

