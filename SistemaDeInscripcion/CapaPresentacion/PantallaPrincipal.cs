using SistemaDeInscripcion.CapaNegociacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInscripcion.CapaPresentacion
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal(ClassUserViewModel objDataUser)
        {
            //string Id, string userName, string NormalizedUserName
            InitializeComponent();
            objDataOfUserLogeado = objDataUser;
            LbIDUser.Text = objDataUser.NormalizedUserName;

        }
        ClassUserViewModel objDataOfUserLogeado = new ClassUserViewModel();

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btinicio_Click(object sender, EventArgs e)
        {
            string msj = string.Empty;
            string ParaCorreoDestino = "warlinsano@gmail.com";
            string TituloAsunto = "Prueva Coreo de enviado C# 1";
            string CuerpoMensaje = "Estoy Probando si Funciona el envio de email desde la app C# 1";

            ClassEnviarCorreo EnviarCorreo = new ClassEnviarCorreo();
            msj = EnviarCorreo.EnviarMail(ParaCorreoDestino, TituloAsunto, CuerpoMensaje);
            MessageBox.Show(msj);
            //EnviarCorreo.TituloAsunto = "";
            //EnviarCorreo.ParaCorreoDestino = "";
            //EnviarCorreo.CuerpoMensaje = "";
        }


        //BOTONES 
        private void BtnEntarFormCursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MantenimientoCursos(objDataOfUserLogeado).Show();
        }

        private void Btirinicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MantenimientoEstudiantes().Show();

        }

        private void BtnIrPublicarNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrublicarNotas().Show();
        }

        private void BtnEntarRegistarAlumno_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MantenimientoEstudiantes().Show();
        }

        private void BtnRegistarCursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MantenimientoCursos(objDataOfUserLogeado).Show();
        }

        private void BtnPublicarNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrublicarNotas().Show();

        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InscripcionEstudiantes().Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //lbHora.Text=DateTime.Now.ToLongTimeString();
            // formato 24 horas lbHora.Text = DateTime.Now.ToString("HH:MM:SS");
            //lbHora.Text = DateTime.Now.ToString("hh:mm:ss");
            //lbFecha.Text = DateTime.Now.ToLongDateString();
            //lbFecha.Text = DateTime.Now.ToShortDateString();
            // lbFecha.Text = DateTime.Now.ToString("dddd MMM yyy");
            lbFechaCorta.Text = DateTime.Now.ToString("dddd MMM yyy");
        }

        private void BtConfigUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opccion aun no se encuentra disponible en esta verccion...", "INFOMAACION DE LA APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Butinformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opccion aun no se encuentra disponible en esta verccion...", "INFOMAACION DE LA APP", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
