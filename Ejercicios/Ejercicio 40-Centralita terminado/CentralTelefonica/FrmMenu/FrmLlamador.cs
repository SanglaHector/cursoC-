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
      public FrmLlamador(Centralita c)
      {
          InitializeComponent();
          this.centralita = c;
          this.comboBox1.DataSource = Enum.GetNames(typeof(CentralitaHerencia.Provincial.Franja));
      }

      private void txtDestino_TextChanged(object sender, EventArgs e)
      {
          if(txtDestino.Text.Length >= 1)
          {
              char numeral = txtDestino.Text.First();
              if(numeral != '#')
              {
                  this.comboBox1.Enabled = false;
              }
          }
      }

      private void button1_Click(object sender, EventArgs e)
      {
          if(this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if(numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '1');
              this.txtDestino.Text = sb.ToString();
          }

      }

      private void Button2_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '2');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button3_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '3');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button4_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '4');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button5_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '5');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button6_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '6');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button7_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '7');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button8_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '8');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void Button9_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '9');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void BtnAsterisco_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '*');
              this.txtDestino.Text = sb.ToString();
          };
      }

      private void Button0_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '0');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void BtnNumeral_Click(object sender, EventArgs e)
      {
          if (this.txtDestino.Text.First() == 'N')
          {
              this.txtDestino.Text = "";
          }
          StringBuilder sb = new StringBuilder();
          string numero = this.txtDestino.Text;
          if (numero.Length < 16)
          {
              sb.Append(this.txtDestino.Text + '#');
              this.txtDestino.Text = sb.ToString();
          }
      }

      private void BtnSalir_Click(object sender, EventArgs e)
      {
          this.DialogResult = DialogResult.OK;
          this.Close();
      }

      private void BtnLlamar_Click(object sender, EventArgs e)
      {
        Random num = new Random();
        Random dec = new Random();
        string cadena = num.Next(0, 5).ToString() + "." + dec.Next(5,6).ToString();
        double final = Convert.ToDouble(cadena);
            
        float costo = (float)final;
        float duracion = num.Next(1, 50);
        string origen = num.Next(1, 99999999).ToString();//this.txtOrigen.Text;
        Provincial.Franja franja;
        Enum.TryParse(this.comboBox1.SelectedItem.ToString(), out franja);
        if (txtDestino.Text.Length > 1)
        {
          if(txtDestino.Text.First() == '#')
          {
              Provincial llamada = new Provincial(origen, franja, duracion, txtDestino.Text);
              this.centralita = centralita + llamada;
              //this.centralita.Llamadas.Add(llamada);
        }
        else
          {
              Local llamada = new Local(origen, duracion, txtDestino.Text, costo);
          //this.centralita.Llamadas.Add(llamada);
          this.centralita = centralita + llamada;
        }
        this.DialogResult = DialogResult.OK;
      }
      else
      {
        this.DialogResult = DialogResult.Cancel;
      }
      }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      txtDestino.Text = "Nro destino";
      txtOrigen.Text = "Nro origen";
    }

    private void FrmLlamador_Load(object sender, EventArgs e)
    {

    }
  }
}
