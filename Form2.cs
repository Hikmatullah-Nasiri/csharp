using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string place = comboBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            string course = listBox1.SelectedItem.ToString();
            label5.Text = name;
            label7.Text = place;
            label10.Text = course;
        }
    }
}
