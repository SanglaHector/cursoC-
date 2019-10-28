using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FrmLlamadaor
{
  public partial class FrmMostrar : Form
  {
        private Centralita centralita;
        public Centralita Centralita
        {
            get
            {
                return centralita;
            }
        }
        public FrmMostrar()
        {
            InitializeComponent();
            this.centralita = 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
