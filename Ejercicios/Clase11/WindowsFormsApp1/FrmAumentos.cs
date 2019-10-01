using Entidades;
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
    public partial class FrmAumentos : Form
    {
        private List<Persona> personas;
        public FrmAumentos()
        {
            InitializeComponent();
            this.personas = new List<Persona>(); 
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in this.personas)
            {
                item.Aumentar(int.Parse(txtPorcentaje.Text));
            }
            this.lstNomina.DataSource = null;
            this.lstNomina.DataSource = personas;
            
        }

    private void FrmAumentos_Load(object sender, EventArgs e)
    {

    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      FrmAdminEmpleados frmAdmin = new FrmAdminEmpleados();
      //frmAdmin.Show();
      if (frmAdmin.ShowDialog() == DialogResult.OK)
      {
        personas.Add(frmAdmin.Persona);
        this.lstNomina.DataSource = null;
        this.lstNomina.DataSource = personas;
        
      }
    }

    private void lstNomina_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
  }
}
