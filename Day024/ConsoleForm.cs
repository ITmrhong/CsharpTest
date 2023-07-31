using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp19
{
    //만들고 싶은 윈도우 <--- Form 클래스 상속
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "버튼:눌러주세요";
            button.Left = 100;
            button.Top = 50;
            button.Click += (object Sender, EventArgs e) =>
            {
                MessageBox.Show("딸깍!");
            };
            MainApp form = new MainApp();
            form.Controls.Add(button);
            Application.Run(form);
           
        }
    }
}
