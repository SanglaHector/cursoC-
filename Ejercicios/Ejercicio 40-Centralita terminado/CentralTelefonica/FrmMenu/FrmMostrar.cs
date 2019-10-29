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
        StringBuilder sb = new StringBuilder();
        InitializeComponent();
        Tipo = tipoDeLlamamada;
        centralita = c;
      if(tipoDeLlamamada == TipoLLamada.Todas)
      {
        this.richMostrar.Text = this.centralita.Mostrar();
      }
      if(tipoDeLlamamada == TipoLLamada.Local)
      {
        foreach (Llamada item in centralita.Llamadas)
        {
          if(item is Local)
          {
            sb.AppendLine(item.ToString());
          }
        }
        this.richMostrar.Text = sb.ToString();
      }
      if(tipoDeLlamamada == TipoLLamada.Provincial)
      {
        foreach (Llamada item in centralita.Llamadas)
        {
          if (item is Provincial)
          {
            sb.AppendLine(item.ToString());
          }
        }
        this.richMostrar.Text = sb.ToString();
      }
        this.DialogResult = DialogResult.OK;
    }
  }
}
