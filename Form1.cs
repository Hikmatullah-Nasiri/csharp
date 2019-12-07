using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string strfile = openFileDialog1.FileName;
                richTextBox1.LoadFile(strfile, RichTextBoxStreamType.PlainText);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strfile = saveFileDialog1.FileName;
                richTextBox1.SaveFile(strfile, RichTextBoxStreamType.PlainText);
            }
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string strfile = folderBrowserDialog1.SelectedPath;
                MessageBox.Show(strfile);
            }
        }
    }
}
