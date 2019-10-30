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
using FrmLlamador;
using FrmLlamadaor;
namespace CentralTelefonica
{
  public partial class FrmMenu : Form
  {
        public Centralita centralita;
        

    public FrmMenu()
    {
      centralita = new Centralita();
      InitializeComponent();
    }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador.FrmLlamador frmLlamador = new FrmLlamador.FrmLlamador(centralita);
        }
    }
}
