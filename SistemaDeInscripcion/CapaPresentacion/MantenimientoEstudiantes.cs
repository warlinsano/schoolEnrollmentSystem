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
    public partial class MantenimientoEstudiantes : Form
    {
        public MantenimientoEstudiantes()
        {
            InitializeComponent();
        }
        private LogicMantEstudiantes CapNegociacion = new LogicMantEstudiantes();
        private ValidacionUtil Validar = new ValidacionUtil();

        //----------Eventos----------------------------------
        private void MantenimientoEstudiantes_Load(object sender, EventArgs e)
        {       
            Gv_Estudiantes.DataSource = CapNegociacion.ListarEstudiantes();
            CountElemtGv_Estudiantes();
            LlenarCombox();
        }
        private void Textbuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbuscar.Text.Trim()) || textbuscar.Text == "Escriba el nombre del participante para buscar")
            {
                Gv_Estudiantes.DataSource = CapNegociacion.ListarEstudiantes();
            }
            else
            {
                Gv_Estudiantes.DataSource = CapNegociacion.ListarEstudiantesNombre(textbuscar.Text.Trim());
            }
            CountElemtGv_Estudiantes();
        }
        private void Textbuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbuscar.Text.Trim()))
            {
                textbuscar.Text = "Escriba el nombre del participante para buscar";
                textbuscar.ForeColor = Color.DimGray;
                //LbErrorPass.Text = "Deve llenar el campo Contraseña";
                //LbErrorPass.Visible = true;
            }
        }
        private void Textbuscar_Enter(object sender, EventArgs e)
        {
            if (textbuscar.Text == "Escriba el nombre del participante para buscar")
            {
                textbuscar.Text = string.Empty;
                textbuscar.ForeColor = Color.Blue;
                //textpass.UseSystemPasswordChar = true;
                //LbErrorPass.Visible = false;
            }
        }
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionUtil.EscribirSoloLetras(e);
        }
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!ValidacionUtil.EsLetras(txtNombre.Text))
            {
                txtNombre.Text = ValidacionUtil.RemplazarNumeros(txtNombre.Text);
                //MessageBox.Show("Solo se permiten Letras");
            }
            txtNombre.Text = ValidacionUtil.Quitar_EspaciosDoblesDobles(txtNombre.Text);
        }
        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionUtil.EscribirSoloLetras(e);
        }
        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            if (!ValidacionUtil.EsLetras(txtApellido.Text))
            {
                txtApellido.Text = ValidacionUtil.RemplazarNumeros(txtApellido.Text);
            }
            txtApellido.Text = ValidacionUtil.Quitar_EspaciosDoblesDobles(txtApellido.Text);

        }
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionUtil.EscribirSoloNumero(e);
        }
        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            if (!ValidacionUtil.EsNumero(txtCedula.Text))
            {
                txtCedula.Text = ValidacionUtil.RemplazarLetras(txtCedula.Text);
            }
            txtCedula.Text = ValidacionUtil.Quitar_EspaciosDoblesDobles(txtCedula.Text);
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionUtil.EscribirSoloNumero(e);
        }
        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!ValidacionUtil.EsNumero(txtTelefono.Text))
            {
                txtTelefono.Text = ValidacionUtil.RemplazarLetras(txtTelefono.Text);
            }
            txtTelefono.Text = ValidacionUtil.Quitar_EspaciosDoblesDobles(txtTelefono.Text);

        }
        private void Gv_Estudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 0) && (e.RowIndex >= 0) && (Gv_Estudiantes.Columns[e.ColumnIndex].Name == "Editar"))
            {
                txtId.Text = Gv_Estudiantes.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtNombre.Text = Gv_Estudiantes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = Gv_Estudiantes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCedula.Text = Gv_Estudiantes.CurrentRow.Cells["Cedula"].Value.ToString();
                txtTelefono.Text = Gv_Estudiantes.CurrentRow.Cells["Telefono"].Value.ToString();
                //Genero....
                if (Gv_Estudiantes.CurrentRow.Cells["Genero"].Value.ToString()=="M")
                {
                    radioButMasculino.Checked = true;
                }
                else
                {
                    radioButFemenino.Checked = true;
                }
                txtFecha_N.Value =DateTime.Parse( Gv_Estudiantes.CurrentRow.Cells["Fecha_N"].Value.ToString());
                txtEmail.Text = Gv_Estudiantes.CurrentRow.Cells["Email"].Value.ToString();
                cbEstado.SelectedValue = Gv_Estudiantes.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

                HabilitarCampos();
                HabilitarBotones(); //botones guardar y Cancelar 
            }

        }

        //---------Eventos Botones--------------------------------
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            HabilitarBotones(); //botones guardar y Cancelar 
        }
        private void ButGuardar_Click(object sender, EventArgs e)
        {

            //string msj = string.Empty;
            //if (!(ValidacionUtil.ValidadCedula(txtCedula.Text, out msj)))
            //{
            //    MessageBox.Show(msj);
            //}

            EstudiantesViewModel estudiantes = new EstudiantesViewModel();
            estudiantes.Nombre = txtNombre.Text;
            estudiantes.Apellido = txtApellido.Text;
            estudiantes.Cedula = txtCedula.Text;
            estudiantes.Telefono = txtTelefono.Text;
            estudiantes.Fecha_N = txtFecha_N.Value;    //date...
            //genero
            if (radioButMasculino.Checked == true)
            {
                estudiantes.Genero = "M";
            }
            if (radioButFemenino.Checked == true)
            {
                estudiantes.Genero = "F";
            }
            estudiantes.Email = txtEmail.Text;
            estudiantes.Estado = cbEstado.SelectedValue.ToString();

            string mensaje = string.Empty;
            //INSERTAR CURSO
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                mensaje = CapNegociacion.InsertarEstudiantes(estudiantes);
            }
            //EDITAR CURSO
            else
            {
                estudiantes.Id = int.Parse(txtId.Text);
                mensaje = CapNegociacion.EditarEstudiantes(estudiantes);
            }
           
            //Solos los mensaje de Correcto Contienen Guiones (-)
            if (mensaje.Contains("-"))
            {
                LimpiarCampos();
                DeshablitarCampos();
                DehabilitarBotones(); //botones guardar y Cancelar 
                Gv_Estudiantes.DataSource = CapNegociacion.ListarEstudiantes();
                CountElemtGv_Estudiantes();
            }
            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshablitarCampos();
            DehabilitarBotones(); //botones guardar y Cancelar 
        }
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
        private void Volver_Click(object sender, EventArgs e)
        {
            ClassErrorOConfirmacion Obj_ErrorOConfirmacion = new ClassErrorOConfirmacion();
           // Obj_ErrorOConfirmacion = CpNegociacion_Login.Login(txtuser.Text.Trim(), textpass.Text.Trim());
            //Oculto el form del login
            this.Hide();
            //muestro el form PantallaPrincipal los detalles estan abajo comentados..
            new PantallaPrincipal(Obj_ErrorOConfirmacion).Show();
        }

        //----------Funciones--------------------------------------
        private void CountElemtGv_Estudiantes()
        {
            if (Gv_Estudiantes.RowCount <= 0)
            {
                LbMsj.Text = "No se Encotraron Registro relacionados a este nombre";
                LbMsj.ForeColor = Color.Red;
            }
            else
            {
                LbMsj.Text = "Se Encotraron " + Gv_Estudiantes.RowCount.ToString() + " Registros Relacionados";
                LbMsj.ForeColor = Color.Blue;
            }
        }
        private void LlenarCombox()
        {
            DataTable dt = new DataTable();
            dt = CapNegociacion.LlenarComboxDb();
            DataRow r = dt.NewRow();
            r["Display"] = "-Seleccionar-";
            r["Value"] = "S";
            dt.Rows.InsertAt(r, 0);
            //Cb_Estado.Items.Insert(0, new ListItem("Selecciona una categoria", "S"));
            //Cb_Estado.Items.Add("-Seleccionar-");
            //Cb_Estado.SelectedIndex = 0;
            cbEstado.DataSource = dt;
            cbEstado.DisplayMember = "Display";
            cbEstado.ValueMember = "Value";
            //Cb_Estado.Text = "Elegir una opcion";

            /*
                  // ddl_ocupacion_categoria.DataValueField = "IdCategoria";
                 // ddl_ocupacion_categoria.DataTextField = "DescripcionCategoria";//indentificador
            ddl_ocupacion_categoria.DataSource = c.select("SELECT IdCategoria, DescripcionCategoria, Estatus FROM  Categoria WHERE Estatus = 'A' ");
            ddl_ocupacion_categoria.DataBind();
            ddl_ocupacion_categoria.Items.Insert(0, new ListItem("Seleccionar", ""));
            ddl_ocupacion_categoria.SelectedIndex = -1;    
            */
        }
        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtFecha_N.Text = string.Empty;
            //genero
            radioButMasculino.Checked = false;
            radioButFemenino.Checked = false;

            txtEmail.Text = string.Empty;
            cbEstado.SelectedIndex = 0;
    

        }
        private void DeshablitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtTelefono.Enabled = false;
            txtFecha_N.Enabled = false;
            //genero
            //genero
            radioButMasculino.Enabled = false;
            radioButFemenino.Enabled = false;

            txtEmail.Enabled = false;
            cbEstado.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtTelefono.Enabled = true;
            txtFecha_N.Enabled = true;
            //genero
            radioButMasculino.Enabled = true;
            radioButFemenino.Enabled = true;

            txtEmail.Enabled = true;
            cbEstado.Enabled = true;
        }
        //habilita el boton Guardar Y Cancelar y Desabilita Nuevo
        private void HabilitarBotones()
        {
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }
        //Deshabilita el boton Guardar Y Cancelar y hasabilita Nuevo
        private void DehabilitarBotones()
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = ValidacionUtil.Quitar_TdodosEspacios(txtEmail.Text);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionUtil.EscribirSinEspacios(e);
        }

    }
}
