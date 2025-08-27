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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int sum1 = Convert.ToInt32(textBox1.Text);
                int sum2 = Convert.ToInt32(textBox2.Text);
                int result = sum1 + sum2;
                label3.Text = $" {sum1} and {sum2} number sum is : {result} ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
