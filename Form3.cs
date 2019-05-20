using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCAP505PracticeApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\work\Documents\DCAP505.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = 
new SqlCommand("insert into signup(username,emailid,phno)values(@username,@emailid,@phno)",con);
            cmd.Parameters.AddWithValue("username", textBox1.Text);
            cmd.Parameters.AddWithValue("emailid", textBox2.Text);
            cmd.Parameters.AddWithValue("phno",int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert done");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
