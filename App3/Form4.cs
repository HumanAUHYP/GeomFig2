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
    public partial class Form4 : Form
    {
        private int[] locationA = new int[2];
        private int[] locationB = new int[2];
        private int[] locationC = new int[2];
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string[] locatString = (tb_LocationA.Text).Split(',');
            locationA[0] = Convert.ToInt32(locatString[0]);
            locationA[1] = Convert.ToInt32(locatString[1]);
            locatString = (tb_LocationB.Text).Split(',');
            locationB[0] = Convert.ToInt32(locatString[0]);
            locationB[1] = Convert.ToInt32(locatString[1]);
            locatString = (tb_LocationC.Text).Split(',');
            locationC[0] = Convert.ToInt32(locatString[0]);
            locationC[1] = Convert.ToInt32(locatString[1]);
            lb_Input.Text = Convert.ToString($"A({locationA[0]}; {locationA[1]}), " +
                                             $"B({locationB[0]}; {locationB[1]}), " +
                                             $"C({locationC[0]}; {locationC[1]})");
        }
    }
}
