using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Frm_Mostrar : Form
  {
    public Persona[] personas;
    public Frm_Mostrar()
    {
      InitializeComponent();
    }

    private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Frm_Mostrar_Load(object sender, EventArgs e)
    {
     for(int i = 0; i < personas.Length; i++)
      {
        this.listPersonas.Items.Add(this.personas[i].Mostrar());
      }
    }
  }
}
