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
        private Form form2;
        private Form form3;
        private Form form4;
        private Form form5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
        }
    }
}
