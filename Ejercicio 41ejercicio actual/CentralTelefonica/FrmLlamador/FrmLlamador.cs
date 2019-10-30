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
namespace FrmLlamador
{
  public partial class FrmLlamador : Form
  {
        private Centralita centralita;
        public Centralita Centralita
        {
            get
            {
                return centralita;
            }
        }
        public FrmLlamador(Centralita centralita)
    {
         InitializeComponent();
         this.centralita = centralita;
    }

  }
}
