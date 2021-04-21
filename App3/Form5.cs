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
    public partial class Form5 : Form
    {
        private int radius;
        private int[] location = new int[2];
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            radius = Convert.ToInt32(tb_Radius.Text);
            string[] locatString = (tb_Location.Text).Split(',');
            location[0] = Convert.ToInt32(locatString[0]);
            location[1] = Convert.ToInt32(locatString[1]);
            lb_Input.Text = Convert.ToString($"Радиус: {radius}, X: {location[0]}, Y: {location[1]}");
        }
    }
}
