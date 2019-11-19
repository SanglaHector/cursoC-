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
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> hilos;
        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;

        }

        private void VistaPatente1_finExposicion(object patente)
        {
            throw new NotImplementedException();
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lista;// = new List<Patente>();
                Xml<List<Patente>> xml = new Xml<List<Patente>>();
                xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\patentes.xml", out lista);
                this.cola = new Queue<Patente>(lista.AsEnumerable().Reverse());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto txt = new Texto();
                txt.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\patentes.txt", out this.cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }
        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                sql.Leer("Patentes", out this.cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }

        private void FinalizarSimulacion()
        {
            if(this.hilos != null)
            {
                foreach (Thread item in hilos)
                {
                    if(item.IsAlive)
                    {
                        item.Abort();
                    }
                }
            }
        }// me fijo que todos los hilos esten muertos
        private void ProximaPatente(Patentes.VistaPatente vp)// si la cola tiene hilos por ejecutar, los ejecuto, los saco de la cola y los agrego a la lista
        {
            if(this.cola.Count > 0 )
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                hilo.Start(this.cola.Dequeue());
                this.hilos.Add(hilo);
            }
        }
        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);
        }
    }
}
