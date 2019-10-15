using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormSistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        public static List<Astro> planetas;

        public FormSistemaSolar()
        {
            InitializeComponent();
            planetas = new List<Astro>();
            this.comboTipo.DataSource = Enum.GetNames(typeof(Tipo));
        }

        private void BtnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            int orbita;
            bool isNumeric = int.TryParse(txtOrbitaPlaneta.Text, out orbita);
            string nombrePlaneta = "";
            int rotacion = 0;
            int satelite = 0;
            if (txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && comboTipo.Text != "" && txtOrbitaPlaneta.Text != "" && isNumeric) 
            {
                bool flag = true;
                int.TryParse(txtOrbitaPlaneta.Text, out orbita);
                rotacion = (int)numRotacion.Value;
                satelite = (int)numSatelites.Value;
                nombrePlaneta = txtNombrePlaneta.Text;
                if(comboTipo.Text == "Gaseoso")
                {
                    Planeta planeta = new Planeta(orbita, rotacion, nombrePlaneta, satelite, Tipo.Gaseoso);
                    foreach (Planeta item in planetas)
                    {
                        if(item == planeta )
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        planetas.Add(planeta);
                        comboPlaneta.Items.Add((string)planeta);
                    }
                }
            else
                {
                    Planeta planeta = new Planeta(orbita, rotacion, nombrePlaneta, satelite, Tipo.Rocoso);
                    foreach (Planeta item in planetas)
                    {
                        if (item == planeta)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        planetas.Add(planeta);
                        comboPlaneta.Items.Add((string)planeta);
                    }
                    else
                    {
                        MessageBox.Show("El planeta ya existe");
                    }
                }
            }
            Clean();
        }

        private void BtnAgregarSatelite_Click(object sender, EventArgs e)
        {
            string planeta = comboPlaneta.Text;
            string satelite = txtNombreSatelite.Text;
            int orbita = (int)numOrbitaSatelite.Value;
            int rotacion = (int)numRotacionSatelite.Value;
            string nombreSatelite;
            bool flag = false;
            if(planeta != "" && satelite != "")
            {
                Satelite unSatelite = new Satelite(orbita, rotacion, satelite);
                foreach (Planeta item in planetas)
                {
                    nombreSatelite = (string)item;
                    if( nombreSatelite.Equals(planeta) )
                    {
                        flag = item + unSatelite;
                    }
                }
            }
            if(planeta == "")
            {
                MessageBox.Show("Ingrese un nombre de planeta");
                flag = true;
            }
            if(satelite == "")
            {
                MessageBox.Show("Ingrese un nombre en el satelite");
                flag = true;
            }
            if(!flag)
            {
                MessageBox.Show("El planeta seleccionado tiene su cantidad de satelites completo o el satelite ya pertenece al planeta");
            }
            Clean();
        }
        void Clean()
        {
            txtNombrePlaneta.Text = "";
            txtNombreSatelite.Text = "";
            txtOrbitaPlaneta.Text = "";
            numOrbitaSatelite.Value = 0;
            numRotacion.Value = 0;
            numRotacionSatelite.Value = 0;
            numSatelites.Value = 0;
        }

        private void Btninfo_Click(object sender, EventArgs e)
        {
            SistemaSolar unSistema = new SistemaSolar();
          //  unSistema = new SistemaSolar();
            string informacion;
            foreach (Astro item in planetas)
            {
                unSistema.Planetas.Add(item);
            }
            informacion = unSistema.MostrarInformacionAstros();
            richTextInfo.Text = informacion;
        }

        private void BtnMoverAstros_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta item in planetas)
            {
                sb.AppendLine("Planeta: " + (string)item);
                sb.AppendLine(item.Rotar());
                sb.AppendLine(item.Orbitar());
                foreach  (Satelite s in item.Stelites)
                {
                    sb.AppendLine("Satelites:" + (string)s);
                    sb.AppendLine(item.Rotar());
                    sb.AppendLine(item.Orbitar());
                } 
            }
            richTextInfo.Text = sb.ToString();
        }
    }
}
