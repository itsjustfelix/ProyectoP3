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
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.cbxVeterinario = new System.Windows.Forms.ComboBox();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Location = new System.Drawing.Point(240, 55);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMascota.TabIndex = 5;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // cbxVeterinario
            // 
            this.cbxVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxVeterinario.FormattingEnabled = true;
            this.cbxVeterinario.Location = new System.Drawing.Point(116, 103);
            this.cbxVeterinario.Name = "cbxVeterinario";
            this.cbxVeterinario.Size = new System.Drawing.Size(199, 24);
            this.cbxVeterinario.TabIndex = 4;
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdMascota.Location = new System.Drawing.Point(116, 18);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.Size = new System.Drawing.Size(199, 22);
            this.txtIdMascota.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veterinario";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombreMascota.Location = new System.Drawing.Point(13, 58);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(126, 20);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "NombreMascota";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombre.Location = new System.Drawing.Point(13, 22);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(88, 20);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Id Mascota";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnBuscarMascota);
            this.groupBox1.Controls.Add(this.cbxVeterinario);
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
            this.groupBox1.Size = new System.Drawing.Size(336, 349);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(169, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 33);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(44, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 33);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTratamiento.Location = new System.Drawing.Point(116, 249);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(199, 39);
            this.txtTratamiento.TabIndex = 1;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDiagnostico.Location = new System.Drawing.Point(116, 197);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(199, 39);
            this.txtDiagnostico.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tratamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnostico";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescripcion.Location = new System.Drawing.Point(116, 152);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 39);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(17, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripcion";
            // 
            // FrmConsultaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 373);
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
        private System.Windows.Forms.ComboBox cbxVeterinario;
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
    }
}