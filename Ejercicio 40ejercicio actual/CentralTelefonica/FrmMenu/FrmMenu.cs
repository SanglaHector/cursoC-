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

namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        public Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
      centralita = new Centralita();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            if (llamador.ShowDialog() == DialogResult.OK)
            {
                centralita = llamador.Centralita;
            }
        }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnFacturacionTotal_Click(object sender, EventArgs e)
    {
      FrmMostrar mostrar = new FrmMostrar(TipoLLamada.Todas,this.centralita);
    }
  }
}
