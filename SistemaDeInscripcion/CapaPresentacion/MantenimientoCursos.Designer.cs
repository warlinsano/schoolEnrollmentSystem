namespace SistemaDeInscripcion.CapaPresentacion
{
    partial class MantenimientoCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCursos));
            this.Gv_cursos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.aterisco1 = new System.Windows.Forms.Label();
            this.aterisco2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreCurso = new System.Windows.Forms.TextBox();
            this.txt_IdCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mostrarID = new System.Windows.Forms.Label();
            this.TipoUserMsj = new System.Windows.Forms.Label();
            this.LbIDUser = new System.Windows.Forms.Label();
            this.LbMsj = new System.Windows.Forms.Label();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.btCerrar = new System.Windows.Forms.PictureBox();
            this.volver = new System.Windows.Forms.PictureBox();
            this.PintureBuscar = new System.Windows.Forms.PictureBox();
            this.panelDeArriba = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_cursos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PintureBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // Gv_cursos
            // 
            this.Gv_cursos.AllowUserToAddRows = false;
            this.Gv_cursos.AllowUserToDeleteRows = false;
            this.Gv_cursos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Gv_cursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Estado,
            this.Editar});
            this.Gv_cursos.Location = new System.Drawing.Point(21, 125);
            this.Gv_cursos.Name = "Gv_cursos";
            this.Gv_cursos.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Gv_cursos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Gv_cursos.Size = new System.Drawing.Size(475, 256);
            this.Gv_cursos.TabIndex = 35;
            this.Gv_cursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_cursos_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "Nombre Del Curso";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lista de Cursos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "BUSCAR:";
            // 
            // textbuscar
            // 
            this.textbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbuscar.ForeColor = System.Drawing.Color.Gray;
            this.textbuscar.Location = new System.Drawing.Point(21, 55);
            this.textbuscar.Multiline = true;
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(303, 21);
            this.textbuscar.TabIndex = 55;
            this.textbuscar.Text = "Escriba el nombre del curso para buscar";
            this.textbuscar.TextChanged += new System.EventHandler(this.Textbuscar_TextChanged);
            this.textbuscar.Enter += new System.EventHandler(this.Textbuscar_Enter);
            this.textbuscar.Leave += new System.EventHandler(this.Textbuscar_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Nuevo);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.aterisco1);
            this.groupBox1.Controls.Add(this.aterisco2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cb_Estado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NombreCurso);
            this.groupBox1.Controls.Add(this.txt_IdCurso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(502, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 256);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION DE CURSO";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(37, 133);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(322, 31);
            this.btn_Nuevo.TabIndex = 61;
            this.btn_Nuevo.Text = "NUEVO";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(37, 170);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(322, 31);
            this.btn_Guardar.TabIndex = 60;
            this.btn_Guardar.Text = "     GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.Indicator;
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(38, 207);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(322, 34);
            this.btn_cancelar.TabIndex = 59;
            this.btn_cancelar.Text = "      &CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // aterisco1
            // 
            this.aterisco1.AutoSize = true;
            this.aterisco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aterisco1.ForeColor = System.Drawing.Color.Red;
            this.aterisco1.Location = new System.Drawing.Point(378, 64);
            this.aterisco1.Name = "aterisco1";
            this.aterisco1.Size = new System.Drawing.Size(14, 16);
            this.aterisco1.TabIndex = 51;
            this.aterisco1.Text = "*";
            this.aterisco1.Visible = false;
            // 
            // aterisco2
            // 
            this.aterisco2.AutoSize = true;
            this.aterisco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aterisco2.ForeColor = System.Drawing.Color.Red;
            this.aterisco2.Location = new System.Drawing.Point(378, 97);
            this.aterisco2.Name = "aterisco2";
            this.aterisco2.Size = new System.Drawing.Size(14, 16);
            this.aterisco2.TabIndex = 50;
            this.aterisco2.Text = "*";
            this.aterisco2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "ESTADO:";
            // 
            // Cb_Estado
            // 
            this.Cb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Estado.Enabled = false;
            this.Cb_Estado.FormattingEnabled = true;
            this.Cb_Estado.Location = new System.Drawing.Point(112, 94);
            this.Cb_Estado.Name = "Cb_Estado";
            this.Cb_Estado.Size = new System.Drawing.Size(247, 21);
            this.Cb_Estado.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "NOMBRE:";
            // 
            // txt_NombreCurso
            // 
            this.txt_NombreCurso.Enabled = false;
            this.txt_NombreCurso.Location = new System.Drawing.Point(112, 60);
            this.txt_NombreCurso.MaxLength = 40;
            this.txt_NombreCurso.Name = "txt_NombreCurso";
            this.txt_NombreCurso.Size = new System.Drawing.Size(247, 20);
            this.txt_NombreCurso.TabIndex = 32;
            this.txt_NombreCurso.TextChanged += new System.EventHandler(this.Txt_NombreCurso_TextChanged);
            this.txt_NombreCurso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NombreCurso_KeyUp);
            // 
            // txt_IdCurso
            // 
            this.txt_IdCurso.Enabled = false;
            this.txt_IdCurso.Location = new System.Drawing.Point(112, 30);
            this.txt_IdCurso.Name = "txt_IdCurso";
            this.txt_IdCurso.Size = new System.Drawing.Size(247, 20);
            this.txt_IdCurso.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID CURSO:";
            // 
            // mostrarID
            // 
            this.mostrarID.AutoSize = true;
            this.mostrarID.Location = new System.Drawing.Point(627, 55);
            this.mostrarID.Name = "mostrarID";
            this.mostrarID.Size = new System.Drawing.Size(52, 13);
            this.mostrarID.TabIndex = 65;
            this.mostrarID.Text = "mostrarID";
            this.mostrarID.Visible = false;
            // 
            // TipoUserMsj
            // 
            this.TipoUserMsj.AutoSize = true;
            this.TipoUserMsj.Location = new System.Drawing.Point(627, 88);
            this.TipoUserMsj.Name = "TipoUserMsj";
            this.TipoUserMsj.Size = new System.Drawing.Size(40, 13);
            this.TipoUserMsj.TabIndex = 64;
            this.TipoUserMsj.Text = "LAVEL";
            // 
            // LbIDUser
            // 
            this.LbIDUser.AutoSize = true;
            this.LbIDUser.Location = new System.Drawing.Point(627, 35);
            this.LbIDUser.Name = "LbIDUser";
            this.LbIDUser.Size = new System.Drawing.Size(52, 13);
            this.LbIDUser.TabIndex = 63;
            this.LbIDUser.Text = "LbIDUser";
            this.LbIDUser.Visible = false;
            // 
            // LbMsj
            // 
            this.LbMsj.AutoSize = true;
            this.LbMsj.Location = new System.Drawing.Point(24, 79);
            this.LbMsj.Name = "LbMsj";
            this.LbMsj.Size = new System.Drawing.Size(35, 13);
            this.LbMsj.TabIndex = 66;
            this.LbMsj.Text = "LbMsj";
            // 
            // btminimizar
            // 
            this.btminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btminimizar.Image")));
            this.btminimizar.Location = new System.Drawing.Point(875, 12);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(20, 21);
            this.btminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminimizar.TabIndex = 68;
            this.btminimizar.TabStop = false;
            this.btminimizar.Click += new System.EventHandler(this.Btminimizar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btCerrar.Image")));
            this.btCerrar.Location = new System.Drawing.Point(904, 12);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(22, 21);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 69;
            this.btCerrar.TabStop = false;
            this.btCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // volver
            // 
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(848, 12);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(20, 21);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volver.TabIndex = 70;
            this.volver.TabStop = false;
            this.volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // PintureBuscar
            // 
            this.PintureBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PintureBuscar.Image")));
            this.PintureBuscar.Location = new System.Drawing.Point(325, 55);
            this.PintureBuscar.Name = "PintureBuscar";
            this.PintureBuscar.Size = new System.Drawing.Size(20, 21);
            this.PintureBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PintureBuscar.TabIndex = 71;
            this.PintureBuscar.TabStop = false;
            // 
            // panelDeArriba
            // 
            this.panelDeArriba.BackColor = System.Drawing.Color.Gold;
            this.panelDeArriba.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeArriba.Location = new System.Drawing.Point(0, 443);
            this.panelDeArriba.Name = "panelDeArriba";
            this.panelDeArriba.Size = new System.Drawing.Size(944, 38);
            this.panelDeArriba.TabIndex = 121;
            // 
            // MantenimientoCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(944, 481);
            this.Controls.Add(this.panelDeArriba);
            this.Controls.Add(this.PintureBuscar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.btminimizar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.LbMsj);
            this.Controls.Add(this.mostrarID);
            this.Controls.Add(this.TipoUserMsj);
            this.Controls.Add(this.LbIDUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.Gv_cursos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoCursos";
            this.Text = "MantenimientoCursos";
            this.Load += new System.EventHandler(this.MantenimientoCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_cursos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PintureBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gv_cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label aterisco1;
        private System.Windows.Forms.Label aterisco2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreCurso;
        private System.Windows.Forms.TextBox txt_IdCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mostrarID;
        private System.Windows.Forms.Label TipoUserMsj;
        private System.Windows.Forms.Label LbIDUser;
        private System.Windows.Forms.Label LbMsj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.PictureBox btminimizar;
        private System.Windows.Forms.PictureBox btCerrar;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.PictureBox PintureBuscar;
        private System.Windows.Forms.Panel panelDeArriba;
    }
}