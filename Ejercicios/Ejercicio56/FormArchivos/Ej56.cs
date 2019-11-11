using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormArchivos
{
    public partial class Ej56 : Form
    {
        public Ej56()
        {
            InitializeComponent();
           
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            string path;
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                StreamReader reader = new StreamReader(path);
                this.richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }else
            {
                Console.WriteLine("Error");
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            string path;
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.Write(this.richTextBox1.Text);
                writer.Close();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Caracteres " + this.richTextBox1.Text.Length);
      this.statusStrip1.Text = sb.ToString();
    }
  }
}
