using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Blue;
        }

        private void RED_BTN_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }

        private void GREEN_BTN_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Green;
        }

        private void CYAN_BTN_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Cyan;
        }

        private void PINK_BTN_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void BLACK_BTN_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
