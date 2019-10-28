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
    public partial class FrmMostrar : Form
    {
    private TipoLLamada tipo;
    private Centralita centralita;
    public Centralita Centralita
    {
      get
      {
        return centralita;
      }
    }
    public TipoLLamada Tipo
    {
      set
      {
        tipo = value;
      }
    }
        public FrmMostrar(TipoLLamada tipoDeLlamamada, Centralita c)
        {
            InitializeComponent();
            Tipo = tipoDeLlamamada;
            centralita = c;
        }

    private void richMostrar_TextChanged(object sender, EventArgs e)
    {

    }

    private void richMostrar_TextChanged_1(object sender, EventArgs e)
    {
      if(tipo == TipoLLamada.Todas)
      {
        this.richMostrar.Text = Centralita.GananciaPorTotal.ToString();
      }
      else if(tipo == TipoLLamada.Provincial)
      {
        this.richMostrar.Text = Centralita.GananciaPorProvincia.ToString();
      }
      else
      {
        this.richMostrar.Text = Centralita.GananciaPorLocal.ToString();
      }
    }
  }
}
