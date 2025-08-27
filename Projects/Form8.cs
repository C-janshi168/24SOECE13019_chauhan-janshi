using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Projects
{
    public partial class Form8 : Form
    {
        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Jhanshi Chauhan\\source\\repos\\24SOECE13019_Chauhan janshi\\Projects\\studentdatabase.mdf\";Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BRANCHTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void branch_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            String query = "insert into register value('" + NAME.Text + "','" + branch_list.SelectedItem.ToString() + "','" + city_list.SelectedItem.ToString() + "','" + PASSWORD.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("register successfully!!!");
        }

        private void NAME_Click(object sender, EventArgs e)
        {

        }
    }
}
