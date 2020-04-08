using SistemaDeInscripcion.CapaNegociacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInscripcion.CapaPresentacion
{
    public partial class PrublicarNotas : Form
    {
        public PrublicarNotas()
        {
            InitializeComponent();
        }

        private void PrublicarNotas_Load(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            ClassErrorOConfirmacion Obj_ErrorOConfirmacion = new ClassErrorOConfirmacion();
            // Obj_ErrorOConfirmacion = CpNegociacion_Login.Login(txtuser.Text.Trim(), textpass.Text.Trim());
            //Oculto el form del login
            this.Hide();
            //muestro el form PantallaPrincipal los detalles estan abajo comentados..
            new PantallaPrincipal(Obj_ErrorOConfirmacion).Show();
        }

        private void Btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //para minimizar
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Cerrar
        }
    }
}
