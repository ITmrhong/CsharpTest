using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 3);//생성자 확인
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 3);
            //그리기 함수들 사용
            Rectangle rectangle = new Rectangle(50, 50, 200, 200);
            g.DrawRectangle(blackPen, rectangle);
            //라인그리기
            Point pt1 = new Point(50, 50);
            Point pt2 = new Point(250, 250);
            g.DrawLine(redPen, pt1, pt2);
            g.DrawLine(redPen, 250, 50, 50, 250);
            Point pt3 = new Point(250, 50);
            Point pt4 = new Point(150, 10);
            Point[] curvePoints =
            {
                pt1,
                pt3,
                pt4

            };
            g.DrawPolygon(redPen,curvePoints );
            //원 그리기
            RectangleF rectf = new RectangleF(50, 50, 200, 200);
            g.DrawEllipse(bluePen, rectf);
            g.FillEllipse(blueBrush, rectf);
            g.FillPolygon(redBrush, curvePoints);
        }
    }
}
