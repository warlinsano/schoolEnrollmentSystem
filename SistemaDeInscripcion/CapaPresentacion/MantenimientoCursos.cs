using SistemaDeInscripcion.CapaNegociacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaDeInscripcion.CapaPresentacion
{
    public partial class MantenimientoCursos : Form
    {
        public MantenimientoCursos(ClassUserViewModel objDataUser)
        {
            InitializeComponent();
            LbIDUser.Text = objDataUser.NormalizedUserName;
        }
        private LogicMantCursos  CapNegociacion = new LogicMantCursos();
        private ValidacionUtil Validacion = new ValidacionUtil();

        //----------Eventos-------------------------------------
        private void MantenimientoCursos_Load(object sender, EventArgs e)
        {
            Gv_cursos.DataSource = CapNegociacion.ListarCursos();
            CountElemtGv_cursos();
            LlenarCombox();
        }
        private void Textbuscar_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textbuscar.Text.Trim()) || textbuscar.Text== "Escriba el nombre del curso para buscar")
            {
                Gv_cursos.DataSource = CapNegociacion.ListarCursos();
            }
            else
            {
                Gv_cursos.DataSource= CapNegociacion.ListarCursosNombre(textbuscar.Text.Trim());
            }
            CountElemtGv_cursos();
        }
        private void Textbuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbuscar.Text.Trim()))
            {
                textbuscar.Text = "Escriba el nombre del curso para buscar";
                textbuscar.ForeColor = Color.DimGray;
                //LbErrorPass.Text = "Deve llenar el campo Contraseña";
                //LbErrorPass.Visible = true;
            }
        }
        private void Textbuscar_Enter(object sender, EventArgs e)
        {
            if (textbuscar.Text == "Escriba el nombre del curso para buscar")
            {
                textbuscar.Text = string.Empty;
                textbuscar.ForeColor = Color.Blue;
                //textpass.UseSystemPasswordChar = true;
                //LbErrorPass.Visible = false;
            }
        }
        private void Gv_cursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 0) && (e.RowIndex >= 0) && (Gv_cursos.Columns[e.ColumnIndex].Name =="Editar"))
            {
                  txt_IdCurso.Text = Gv_cursos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                  txt_NombreCurso.Text = Gv_cursos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                  Cb_Estado.SelectedValue= Gv_cursos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                //txt_IdCurso.Text = Gv_cursos.CurrentRow.Cells["Id"].Value.ToString();
                //txt_NombreCurso.Text = Gv_cursos.CurrentRow.Cells["Nombre"].Value.ToString();

                HabilitarCampos();
                HabilitarBotones(); //botones guardar y Cancelar 
            }
        }
        private void Txt_NombreCurso_KeyUp(object sender, KeyEventArgs e)
        {
            txt_NombreCurso.Text = ValidacionUtil.QuitarEspaciosDoble(txt_NombreCurso.Text);
        }
        private void Txt_NombreCurso_TextChanged(object sender, EventArgs e)
        {

            txt_NombreCurso.Text = ValidacionUtil.QuitarEspaciosDoble(txt_NombreCurso.Text);

            //string Cadena, Msj=string.Empty;
            //Cadena = txt_NombreCurso.Text;
            //for (int x = 0; x < Cadena.Length; x++)
            //{
            //    if (Cadena[x] >= '0' && Cadena[x] <= '9')
            //    {
            //    }
            //    else
            //    {
            //        Msj = "Solo se permiten numeros";
            //        txt_NombreCurso.Focus();
            //        txt_NombreCurso.Text = "";
            //    }
            //}
            //    MessageBox.Show(Msj);
        }

       
        //---------Eventos Botones--------------------------------
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            HabilitarBotones(); //botones guardar y Cancelar 
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje=string.Empty;
            //INSERTAR CURSO
            if (string.IsNullOrEmpty(txt_IdCurso.Text.Trim()))
            {
                mensaje = CapNegociacion.InsertarCursos(txt_NombreCurso.Text, Cb_Estado.SelectedValue.ToString());
            }
            //EDITAR CURSO
            else
            {
                CursosViewModel CURSO = new CursosViewModel();
                CURSO.Id = int.Parse(txt_IdCurso.Text);
                CURSO.Nombre = txt_NombreCurso.Text;
                CURSO.Estado = Cb_Estado.SelectedValue.ToString();
                mensaje = CapNegociacion.EditarCursos(CURSO);
            }
            //Solos los mensaje de Correcto Contienen Guiones (-)
            if (mensaje.Contains("-")){ 
                LimpiarCampos();
                DeshablitarCampos();
                DehabilitarBotones(); //botones guardar y Cancelar 
                Gv_cursos.DataSource = CapNegociacion.ListarCursos();
                CountElemtGv_cursos();
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

        //----------Funciones-----------------------------------------
        private void CountElemtGv_cursos()
        {
            if (Gv_cursos.RowCount <= 0)
            {
                LbMsj.Text = "No se Encotraron Registro relacionados a este nombre";
                LbMsj.ForeColor = Color.Red;
            }
            else
            {
                LbMsj.Text = "Se Encotraron " + Gv_cursos.RowCount.ToString() + " Registros Relacionados";
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
            Cb_Estado.DataSource = dt;
            Cb_Estado.DisplayMember = "Display";
            Cb_Estado.ValueMember = "Value";
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
            txt_IdCurso.Text = string.Empty;
            txt_NombreCurso.Text = string.Empty;
            Cb_Estado.SelectedIndex = 0;
        }
        private void DeshablitarCampos()
        {
            txt_NombreCurso.Enabled = false;
            Cb_Estado.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txt_NombreCurso.Enabled = true;
            Cb_Estado.Enabled = true;
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


    }
}
