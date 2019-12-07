using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kumar\Documents\DCAP505DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update studentDetailstbl set password=@password,email=@email,course=@course where username=@username", con);
            cmd.Parameters.AddWithValue("username", textBox1.Text);
            cmd.Parameters.AddWithValue("password", textBox3.Text);
            cmd.Parameters.AddWithValue("email", textBox2.Text);
            cmd.Parameters.AddWithValue("course", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data updated");
        }
    }
}
