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
using SistemaDeInscripcion.CapaNegociacion;

namespace SistemaDeInscripcion.CapaPresentacion
{
    public partial class Login : Form
    {
        //para poder arastrar el formulario con el mouse
        #region ArrastrarForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public Login()
        {
            InitializeComponent();
        }

        //----------Eventos---------------
        private void LbTitle_Click(object sender, EventArgs e)
        {
            // llamar metodo anterior en evento MouseMove de cualquier control (panel, picture box) ó Form Propio 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            // llamar metodo anterior en evento MouseMove de cualquier control (panel, picture box) ó Form Propio 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void LbTitle_MouseMove(object sender, MouseEventArgs e)
        {
            // llamar metodo anterior en evento MouseMove de cualquier control (panel, picture box) ó Form Propio 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // llamar metodo anterior en evento MouseMove de cualquier control (panel, picture box) ó Form Propio 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // llamar metodo anterior en evento MouseMove de cualquier control (panel, picture box) ó Form Propio 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Txtuser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text.Trim()))
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
                LbErrorUsuario.Text = "Deve llenar el campo Usuario";
                LbErrorUsuario.Visible = true;
            }
        }
        private void Txtuser_Enter(object sender, EventArgs e)
        {
            //para que se borrer el placeolder
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = string.Empty;
                txtuser.ForeColor = Color.Blue;
                LbErrorUsuario.Visible = false;
            }
        }

        private void Textpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textpass.Text.Trim()))
            {
                textpass.Text = "CONTRASEÑA";
                textpass.ForeColor = Color.DimGray;
                textpass.UseSystemPasswordChar = false;
                LbErrorPass.Text = "Deve llenar el campo Contraseña";
                LbErrorPass.Visible = true;
            }
        }

        private void Textpass_Enter(object sender, EventArgs e)
        {
            if (textpass.Text == "CONTRASEÑA")
            {
                textpass.Text = string.Empty;
                textpass.ForeColor = Color.Blue;
                textpass.UseSystemPasswordChar = true;
                LbErrorPass.Visible = false;
            }
        }

    

        //----------Botones------------------
        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Cerrar
        }
        private void Btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //para minimizar
        }
        private void Btentrar_Click(object sender, EventArgs e)
        {
            LbErrorLogin.Visible = false;
            if (string.IsNullOrEmpty(txtuser.Text.Trim()) || txtuser.Text == "USUARIO")
            {
                    txtuser.ForeColor = Color.DimGray;
                    LbErrorUsuario.Text = "Deve llenar el campo Usuario";
                    LbErrorUsuario.Visible = true;
                    txtuser.Text = "USUARIO";
                    //txtuser.Text=txtuser.Text.Trim();
                    //txtuser.Focus();
            }
            else if (string.IsNullOrEmpty(textpass.Text.Trim()) || textpass.Text == "CONTRASEÑA")
            {
                    textpass.ForeColor = Color.DimGray;
                    textpass.UseSystemPasswordChar = false;
                    LbErrorPass.Text = "Deve llenar el campo Contraseña";
                    LbErrorPass.Visible = true;
                    textpass.Text = "CONTRASEÑA";
                    //textpass.Text = textpass.Text.Trim();
                    //textpass.Focus();              
            }
            else
            {
                ClassErrorOConfirmacion Obj_ErrorOConfirmacion = new ClassErrorOConfirmacion();
                ClassLogin CpNegociacion_Login = new ClassLogin();
                Obj_ErrorOConfirmacion = CpNegociacion_Login.Login(txtuser.Text.Trim(), textpass.Text.Trim());
                if (Obj_ErrorOConfirmacion.EstadoConfirmacion)
                {
                    //Oculto el form del login
                    this.Hide();

                    //muestro el form PantallaPrincipal los detalles estan abajo comentados..
                    new PantallaPrincipal(Obj_ErrorOConfirmacion).Show();
                    // new PantallaPrincipal().Show() .... para llamar el formulario y le paso el objeto lleno con los datos del
                    //usuario para manejar una especiede seccion y tener un control del usuario logeado 
                }
                else
                {

                    if (Obj_ErrorOConfirmacion.TipoErrorOConfirmacion == "Msj_Lavel")
                    {
                        //Usuario o clave incorreta usuario desavilitado, bloqueado por intentos fallidos, bacasiones, etc.....
                        LbErrorLogin.Text = Obj_ErrorOConfirmacion.MensajeError;
                        LbErrorLogin.Visible = true;
                    }
                    else
                    {
                        //cualquier otro tipo de mjs va aki...
                        if(Obj_ErrorOConfirmacion.TipoErrorOConfirmacion == "Msj_Emergente_Error") { 
                             MessageBox.Show(Obj_ErrorOConfirmacion.MensajeError, Obj_ErrorOConfirmacion.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //LbErrorLogin.Text = Obj_ErrorOConfirmacion.Titulo;
                            //LbErrorLogin.Visible = true;
                        }
                        if (Obj_ErrorOConfirmacion.TipoErrorOConfirmacion == "Msj_Emergente_Info")
                        {
                            MessageBox.Show(Obj_ErrorOConfirmacion.MensajeError, Obj_ErrorOConfirmacion.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LbErrorLogin.Text = Obj_ErrorOConfirmacion.Titulo;
                            //LbErrorLogin.Visible = true;
                        }
                    }
                }
            }
        }

        //pendiente 
        //poner un boton como imagen para poder ver la clave o pwd


    }
}
