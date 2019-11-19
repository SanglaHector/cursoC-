using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Entities;
using Persistencia;
namespace SegundoParcial
{
    public partial class FrmSender : Form
    {
        private readonly List<Thread> hilos;

        public FrmSender()
        {
            InitializeComponent();
            hilos = new List<Thread>();
        }

        /// <summary>
        /// El botón Enviar Email debe crear un EmisorDeEmails, agregar al eventMensaje el 
        /// manejador “EmailDB.Guardar” y “MostrarMensaje” y ejecutar el método EnviarMensaje 
        /// (del objeto EmisorDeEmails) en un hilo nuevo. (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            EProducto ep;
            EmailDB db = new EmailDB();
            Enum.TryParse(cmbProducto.Text, out ep);
            EmisorDeEmails em = new EmisorDeEmails(richMensaje.Text, ep, txtEmail.Text);
            em.EventMensaje += new EnviarMensajeDelegate(db.Guardar);
            em.EventMensaje += new EnviarMensajeDelegate(MostrarMensaje);
            Thread h = new Thread(em.EnviarMensaje);
            hilos.Add(h);
            h.Start();
        }
        /// <summary>
        /// Email info utilizarán las clase EmailDb para traer la 
        /// información de la base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMailInfo_Click(object sender, EventArgs e)
        {
            EmailDB db = new EmailDB();
            List<EmisorDeEmails> emisores= new List<EmisorDeEmails>();
            emisores = db.Leer();
            foreach (EmisorDeEmails emisor in emisores)
            {
                richOutPut.Text = richOutPut.Text + emisor.ToString()+"\n";
            }
            
        }

        /// <summary>
        /// El botón Enviar Whatsapp hace lo mismo con el objeto EmisorDeWhatsapp per 
        /// agrega al event eventMensaje el manejador “WhatsappTexto.Guardar” y “MostrarMensaje” 
        /// y ejecutar el método EnviarMensaje (del objeto EmisorDeEmails) en un hilo nuevo. 
        /// (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendWhat_Click(object sender, EventArgs e)
        {
            EProducto ep;
            WhatsappTexto wt = new WhatsappTexto();
            Enum.TryParse(cmbProducto.Text, out ep);
            EmisorDeWhatsapp ew = new EmisorDeWhatsapp(richMensaje.Text, ep);
            ew.EventMensaje += new EnviarMensajeDelegate(wt.Guardar);
            ew.EventMensaje += new EnviarMensajeDelegate(MostrarMensaje);
            Thread h = new Thread(ew.EnviarMensaje);
            hilos.Add(h);
            h.Start();
        }

        /// <summary>
        /// Whatsapp info utilizarán las clase WhatsappTexto para traer la información de la 
        /// base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWhatInfo_Click(object sender, EventArgs e)
        {
            WhatsappTexto wt = new WhatsappTexto();
            richOutPut.Text = wt.Leer();
        }

        /// <summary>
        /// recibe un objeto del tipo Emisor y muestra en un MessageBox el siguiente mensaje: 
        /// $"{mensaje.GetType().Name} - Se envió mensaje del producto: {mensaje.Producto}”
        /// </summary>
        /// <param name="emisor"></param>
        private void MostrarMensaje(Emisor emisor)
        {
            MessageBox.Show($"{emisor.GetType().Name}-Se envio mendaje del producto: {emisor.Producto}");
        }

        /// <summary>
        /// Cuando se cierra la aplicación abortar todos los hilos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSender_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Thread h in hilos)
            {
                h.Abort();
            }
        }
    }
}
