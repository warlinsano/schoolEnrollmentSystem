namespace SistemaDeInscripcion.CapaPresentacion
{
    partial class MantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.PictureBox();
            this.btminimizar = new System.Windows.Forms.PictureBox();
            this.btCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta panatalla aun esta en Desarrollo";
            // 
            // volver
            // 
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(1147, 12);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(20, 21);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volver.TabIndex = 73;
            this.volver.TabStop = false;
            // 
            // btminimizar
            // 
            this.btminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btminimizar.Image")));
            this.btminimizar.Location = new System.Drawing.Point(1174, 12);
            this.btminimizar.Name = "btminimizar";
            this.btminimizar.Size = new System.Drawing.Size(20, 21);
            this.btminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btminimizar.TabIndex = 71;
            this.btminimizar.TabStop = false;
            // 
            // btCerrar
            // 
            this.btCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btCerrar.Image")));
            this.btCerrar.Location = new System.Drawing.Point(1203, 12);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(22, 21);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 72;
            this.btCerrar.TabStop = false;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1272, 549);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.btminimizar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenimientoUsuarios";
            this.Text = "MantenimientoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.PictureBox btminimizar;
        private System.Windows.Forms.PictureBox btCerrar;
    }
}