namespace SistemaDeInscripcion.CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LbErrorLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFechaCorta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbErrorPass = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.LbErrorUsuario = new System.Windows.Forms.Label();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.btCerrar = new System.Windows.Forms.PictureBox();
            this.btentrar = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LbErrorLogin
            // 
            this.LbErrorLogin.AutoSize = true;
            this.LbErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.LbErrorLogin.Location = new System.Drawing.Point(254, 171);
            this.LbErrorLogin.Name = "LbErrorLogin";
            this.LbErrorLogin.Size = new System.Drawing.Size(64, 13);
            this.LbErrorLogin.TabIndex = 32;
            this.LbErrorLogin.Text = "LbErrorPass";
            this.LbErrorLogin.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lbHora);
            this.panel1.Controls.Add(this.lbFechaCorta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 267);
            this.panel1.TabIndex = 22;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(54, 217);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(38, 13);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "lbHora";
            this.lbHora.Visible = false;
            // 
            // lbFechaCorta
            // 
            this.lbFechaCorta.AutoSize = true;
            this.lbFechaCorta.Location = new System.Drawing.Point(50, 197);
            this.lbFechaCorta.Name = "lbFechaCorta";
            this.lbFechaCorta.Size = new System.Drawing.Size(70, 13);
            this.lbFechaCorta.TabIndex = 1;
            this.lbFechaCorta.Text = "lbFechaCorta";
            this.lbFechaCorta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // LbErrorPass
            // 
            this.LbErrorPass.AutoSize = true;
            this.LbErrorPass.ForeColor = System.Drawing.Color.Blue;
            this.LbErrorPass.Location = new System.Drawing.Point(239, 153);
            this.LbErrorPass.Name = "LbErrorPass";
            this.LbErrorPass.Size = new System.Drawing.Size(64, 13);
            this.LbErrorPass.TabIndex = 31;
            this.LbErrorPass.Text = "LbErrorPass";
            this.LbErrorPass.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbTitle.Location = new System.Drawing.Point(344, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(90, 30);
            this.lbTitle.TabIndex = 25;
            this.lbTitle.Text = "LOGIN";
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LbTitle_MouseMove);
            // 
            // LbErrorUsuario
            // 
            this.LbErrorUsuario.AutoSize = true;
            this.LbErrorUsuario.ForeColor = System.Drawing.Color.Blue;
            this.LbErrorUsuario.Location = new System.Drawing.Point(239, 102);
            this.LbErrorUsuario.Name = "LbErrorUsuario";
            this.LbErrorUsuario.Size = new System.Drawing.Size(77, 13);
            this.LbErrorUsuario.TabIndex = 30;
            this.LbErrorUsuario.Text = "LbErrorUsuario";
            this.LbErrorUsuario.Visible = false;
            // 
            // btminimizar
            // 
            this.btminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btminimizar.Image")));
            this.btminimizar.Location = new System.Drawing.Point(543, 12);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(20, 21);
            this.btminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminimizar.TabIndex = 23;
            this.btminimizar.TabStop = false;
            this.btminimizar.Click += new System.EventHandler(this.Btminimizar_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkpass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkpass.Location = new System.Drawing.Point(270, 231);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(179, 17);
            this.linkpass.TabIndex = 29;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Ha ovidado la contraseña";
            // 
            // btCerrar
            // 
            this.btCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btCerrar.Image")));
            this.btCerrar.Location = new System.Drawing.Point(573, 12);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(22, 21);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 24;
            this.btCerrar.TabStop = false;
            this.btCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // btentrar
            // 
            this.btentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.btentrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btentrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btentrar.Location = new System.Drawing.Point(257, 187);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(211, 32);
            this.btentrar.TabIndex = 28;
            this.btentrar.Text = "ACCEDER";
            this.btentrar.UseVisualStyleBackColor = false;
            this.btentrar.Click += new System.EventHandler(this.Btentrar_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtuser.Location = new System.Drawing.Point(241, 76);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(240, 19);
            this.txtuser.TabIndex = 26;
            this.txtuser.Text = "USUARIO";
            this.txtuser.Enter += new System.EventHandler(this.Txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.Txtuser_Leave);
            // 
            // textpass
            // 
            this.textpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textpass.Location = new System.Drawing.Point(241, 131);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(240, 19);
            this.textpass.TabIndex = 27;
            this.textpass.Text = "CONTRASEÑA";
            this.textpass.Enter += new System.EventHandler(this.Textpass_Enter);
            this.textpass.Leave += new System.EventHandler(this.Textpass_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(607, 267);
            this.Controls.Add(this.LbErrorLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbErrorPass);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.LbErrorUsuario);
            this.Controls.Add(this.btminimizar);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.textpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "LOGIN";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbErrorLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFechaCorta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbErrorPass;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label LbErrorUsuario;
        private System.Windows.Forms.PictureBox btminimizar;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox btCerrar;
        private System.Windows.Forms.Button btentrar;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox textpass;
    }
}