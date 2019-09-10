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
  public partial class Form1 : Form
  {
    Persona[] personas;
    public Form1()
    {
      InitializeComponent();
      this.personas = new Persona[3];
    }
    #region Cosas
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void labelNombre_Click(object sender, EventArgs e)
    {

    }

    private void labelApellido_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
    #endregion


    private void botonAceptar_Click(object sender, EventArgs e)
    {
      int dni;
      if(DialogResult.Yes == MessageBox.Show("Esta seguro?","Atencion",MessageBoxButtons.YesNo , MessageBoxIcon.Question ))
      {
        if(int.TryParse(this.textBoxDNI.Text, out dni))
        {
          Persona unaPersona = new Persona(this.textBoxNombre.Text, this.textBoxApellido.Text, dni);
          for(int i = 0; i < personas.Length; i++)
          {
            if(personas[i] == null)
            {
              personas[i] = unaPersona;
            }
          }
        }

      }
    }
    private void Limpiar()
    {
      this.textBoxNombre.Text = "";
      this.textBoxApellido.Text = "";
      this.textBoxDNI.Text = "";
    }
  }
}
