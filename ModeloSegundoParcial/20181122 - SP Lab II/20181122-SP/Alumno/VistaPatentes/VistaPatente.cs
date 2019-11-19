using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Entidades;

namespace Patentes
{
    public delegate void FinExposicionPatente(VistaPatente vp);
    public delegate void MostrarPatente(object patente);

    public partial class VistaPatente : UserControl
    {
        public event FinExposicionPatente finExposicion;
        public VistaPatente()
        {
            InitializeComponent();

            picPatente.Image = fondosPatente.Images[(int)Patente.Tipo.Mercosur];
        }

        public void MostrarPatente(object patente)
        {
            if (lblPatenteNro.InvokeRequired)
            {
                try
                {
                    Random r = new Random();

                    // Llamar al hilo principal
                    // ALUMNO Hector Sangla
                    lblPatenteNro.Invoke(new MostrarPatente(this.MostrarPatente), patente);
                    // lblPatenteNro es un control visual, un hilo. 
                    //Invoke llama al hilo a que se ejecute y como parametro les pasa el delegado 
                    //el delegado a su vez funciona como un puntero a una funcion. En este caso a si mismo
                    Thread.Sleep(r.Next(2000, 5000));
                    // Agregar evento de que finalizó la exposición de la patente
                    this.finExposicion(this);
                    // ALUMNO
                }
                catch (Exception) { }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }

    }
}
