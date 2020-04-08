using SistemaDeInscripcion.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //para poder arractar

namespace SistemaDeInscripcion.CapaPresentacion
{
    public partial class Inicio : Form
    {
        //para poder arastrar el formulario con el mouse
        #region ArrastrarForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public Inicio()
        {
            InitializeComponent();
        }
        //conexion a la Db
        //private ContextosDatosDB db = new ContextosDatosDB();
        private void Inicio_Load(object sender, EventArgs e)
        {
            //GvCursos.DataSource = db.Cursos.ToList();
            //carge en el from en inicio del timer1
            this.timer1.Start();
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            //barra de carga...    
            this.progressBar1.Increment(1);

            if (this.progressBar1.Value == 50)
            {
                this.progressBar1.Value = 0;
                this.timer1.Stop();
                //MessageBox.Show("entrar");
                this.Hide();
                Login frm = new Login();
                //FormMenuPrincipal frm = new FormMenuPrincipal();
                frm.Show();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
            // llamar metodo anterior en evento MouseMove de cualquier control (panel, picture box) ó Form Propio 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
