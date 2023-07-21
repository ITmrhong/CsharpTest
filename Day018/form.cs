using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bigbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요 윈도우프로그램입니다");
            Trace.WriteLine(string.Format($"{System.DateTime.Now}: 출력메시지"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#의 세상에 오신 것을 환영합니다.");
        }
    }
}
