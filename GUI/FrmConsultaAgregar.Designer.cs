namespace ProyectoP3
{
    partial class FrmConsultaAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAgregar));
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.cbmVeterinario = new System.Windows.Forms.ComboBox();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEspecializacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Location = new System.Drawing.Point(271, 37);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMascota.TabIndex = 5;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // cbmVeterinario
            // 
            this.cbmVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbmVeterinario.FormattingEnabled = true;
            this.cbmVeterinario.Location = new System.Drawing.Point(163, 131);
            this.cbmVeterinario.Name = "cbmVeterinario";
            this.cbmVeterinario.Size = new System.Drawing.Size(183, 24);
            this.cbmVeterinario.TabIndex = 4;
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdMascota.Location = new System.Drawing.Point(163, 9);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.Size = new System.Drawing.Size(183, 22);
            this.txtIdMascota.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veterinario";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(7, 57);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(132, 18);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "NombreMascota";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(7, 13);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(90, 18);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Id Mascota";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbEspecializacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnBuscarMascota);
            this.groupBox1.Controls.Add(this.cbmVeterinario);
            this.groupBox1.Controls.Add(this.txtTratamiento);
            this.groupBox1.Controls.Add(this.txtDiagnostico);
            this.groupBox1.Controls.Add(this.txtIdMascota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNombreMascota);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbEspecializacion
            // 
            this.cmbEspecializacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbEspecializacion.FormattingEnabled = true;
            this.cmbEspecializacion.Location = new System.Drawing.Point(163, 92);
            this.cmbEspecializacion.Name = "cmbEspecializacion";
            this.cmbEspecializacion.Size = new System.Drawing.Size(183, 24);
            this.cmbEspecializacion.TabIndex = 19;
            this.cmbEspecializacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecializacion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Especializacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescripcion.Location = new System.Drawing.Point(116, 171);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 20);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripcion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(189, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 43);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(33, 283);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 43);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTratamiento.Location = new System.Drawing.Point(116, 240);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(230, 20);
            this.txtTratamiento.TabIndex = 1;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDiagnostico.Location = new System.Drawing.Point(116, 206);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(230, 20);
            this.txtDiagnostico.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tratamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnostico";
            // 
            // FrmConsultaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 365);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaAgregar";
            this.Text = "FrmConsultaAgregar";
            this.Load += new System.EventHandler(this.FrmConsultaAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarMascota;
        private System.Windows.Forms.ComboBox cbmVeterinario;
        private System.Windows.Forms.TextBox txtIdMascota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecializacion;
        private System.Windows.Forms.Label label5;
    }
}