using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics formGraphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 100, 100, 200, 100);
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 100, 200, 300);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, rect);
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            PointF[] points = new PointF[3];
            points[0] = new Point(50, 50);
            points[1] = new Point(150, 50);
            points[2] = new Point(250, 150);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawPolygon(myPen, points);
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 100, 200, 300);
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, rect);
        }
    }
}
