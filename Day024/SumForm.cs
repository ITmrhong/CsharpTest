using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            int n= int.Parse(textBox1.Text);
            int result = 0;
            int result2 = 0;
            for (int i = 1; i <= n; i++)
            {
            
                if (i % 2 == 1)
                {
                    textBox2.Text += i.ToString() + " + ";
                    result += i;
                }
                else
                {
                    textBox3.Text += i.ToString() + " + ";
                    result2 += i;
                }
            }
            
       
            textBox2.Text += textBox2.Text.TrimEnd('+', ' ') +" =  " +result.ToString();
            textBox3.Text += textBox3.Text.TrimEnd('+', ' ') +" =  " + result2.ToString();
        }
    }
}
