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
    public partial class FrmAdminEmpleados : Form
    {

     private Persona persona;
    public FrmAdminEmpleados()
    {
      InitializeComponent();
    }
    public Persona Persona
    {
      get
      {
        return this.persona;
      }
    }
    private void FrmAdminEmpleados_Load(object sender, EventArgs e)
        {

            this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            switch ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem)
            {
                case ETipoEmpleado.Empleado:
                    try
                    {
                      if(Persona.validarCuil(double.Parse(this.txtCuil.Text)))
                      {
                        this.persona = (new Empleado(this.txtNombre.Text,double.Parse(this.txtCuil.Text ),float.Parse(this.txtSueldo.Text )));
                      }
                    }
                    catch (Exception ex)
                    {
                       Console.WriteLine(ex.Message);
                    }
                    break;
                case ETipoEmpleado.Jefe:
                try
                {
                      double aux = double.Parse(this.txtCuil.Text);
                      if (Persona.validarCuil(aux))
                        {
                          this.persona = (new Jefe(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text),int.Parse(this.txtBono.Text))); ;
                        }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
          }
                    break;
                case ETipoEmpleado.Vendedor:
                  try
                  {
                    if (Persona.validarCuil(double.Parse(this.txtCuil.Text)))
                    {
                      this.persona = (new Vendedor(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text),int.Parse(this.txtObjetivo.Text)));
                    }
                  }catch(Exception ex )
                  {
                     Console.WriteLine(ex.Message);
                     Console.ReadKey();
                  }
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.limpiar();
        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblBono.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            this.txtBono.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            this.lblObjetivo.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
            this.txtObjetivo.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
        }
        private void limpiar()
        {
            this.limpiarControles(this.Controls);
        }

        private void limpiarControles(System.Windows.Forms.Control.ControlCollection c)
        {
            foreach (Control item in c)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is Panel)
                    this.limpiarControles(((Panel)item).Controls);

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //foreach (Persona item in this.personas)
            //{
            //    MessageBox.Show(item.Mostrar());                

            //}
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            //FrmAumentos frmAumentos = new FrmAumentos(this.personas);
            
        }
    }
}
