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
        Pen myPen = new Pen(Color.Black, 2);
        Graphics paper;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            paper = board.CreateGraphics();
            paper.DrawLine(myPen, 100, 100, 200, 100);
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 100, 200, 300);
            paper = board.CreateGraphics();
            paper.DrawRectangle(myPen, rect);
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            PointF[] points = new PointF[3];
            points[0] = new Point(50, 50);
            points[1] = new Point(150, 50);
            points[2] = new Point(250, 150);
            paper = board.CreateGraphics();
            paper.DrawPolygon(myPen, points);
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(150, 100, 200, 300);
            paper = board.CreateGraphics();
            paper.DrawEllipse(myPen, rect);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = dlgColor.Color;
                myPen.Color = dlgColor.Color;
            }
        }

        private void lbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            myPen.Width = Convert.ToInt32(lbWidth.SelectedItem);
        }
    }
}
