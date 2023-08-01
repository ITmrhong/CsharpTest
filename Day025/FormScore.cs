using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Score(int score)
        {
                if (100 < score || score < 0)
                {
                    MessageBox.Show("0~100 점수를 입력하세요");
                    return "";
                }
                else if (score >= 95)
                    return "A+";
                else if (score >= 90)
                    return "A";
                else if (score >= 85)
                    return "B+";
                else if (score >= 80)
                    return "B";
                else if (score >= 75)
                    return "C";
                else
                    return "F";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textBox1.Text);
            textBox2.Text = Score(score);
            


        }
    }
}
