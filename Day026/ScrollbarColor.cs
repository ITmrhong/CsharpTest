using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        private int R=0, G=0, B=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void panelcolor()
        {
            panel1.BackColor = Color.FromArgb(R, G, B);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
            panelcolor();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
            panelcolor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            panelcolor();
        }   
    }
}
