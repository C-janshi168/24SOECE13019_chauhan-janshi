namespace Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_ENTER_Click(object sender, EventArgs e)
        {
            {
                label4.Visible = true;
                label4.Text = "i am " + textBox1.Text + " from " + textBox2.Text;

                MessageBox.Show("i am " + textBox1.Text + " from " + textBox2.Text);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
