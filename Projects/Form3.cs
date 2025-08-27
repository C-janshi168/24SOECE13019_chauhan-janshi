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
    public partial class Form3 : Form
    {
        double firstno, secondno, ans;
        string op = " ";
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secondno = Convert.ToDouble(richTextBox1.Text);
            if (op == "+")
            {
                richTextBox1.Text = Convert.ToString(firstno + secondno);

            }
            else if (op == "-")
            {
                richTextBox1.Text = Convert.ToString(firstno - secondno);
            }
            else if (op == "-")
            {
                richTextBox1.Text = Convert.ToString(firstno * secondno);
            }
            else if (op == "-")
            {
                richTextBox1.Text = Convert.ToString(firstno / secondno);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "+";

        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "-";
        }

        private void mul_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "*";
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            firstno = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            op = "/";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
