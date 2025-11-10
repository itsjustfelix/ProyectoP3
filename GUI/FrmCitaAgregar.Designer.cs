namespace ProyectoP3
{
    partial class FrmCitaAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitaAgregar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVeterianrio = new System.Windows.Forms.ComboBox();
            this.cmbEspecializacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DTPHora = new System.Windows.Forms.DateTimePicker();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbVeterianrio);
            this.groupBox1.Controls.Add(this.cmbEspecializacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.DTPHora);
            this.groupBox1.Controls.Add(this.DTPFecha);
            this.groupBox1.Controls.Add(this.btnBuscarMascota);
            this.groupBox1.Controls.Add(this.txtIdMascota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombreMascota);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 347);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbVeterianrio
            // 
            this.cmbVeterianrio.BackColor = System.Drawing.Color.LightGray;
            this.cmbVeterianrio.FormattingEnabled = true;
            this.cmbVeterianrio.Location = new System.Drawing.Point(163, 154);
            this.cmbVeterianrio.Name = "cmbVeterianrio";
            this.cmbVeterianrio.Size = new System.Drawing.Size(183, 21);
            this.cmbVeterianrio.TabIndex = 21;
            // 
            // cmbEspecializacion
            // 
            this.cmbEspecializacion.BackColor = System.Drawing.Color.LightGray;
            this.cmbEspecializacion.FormattingEnabled = true;
            this.cmbEspecializacion.Location = new System.Drawing.Point(163, 114);
            this.cmbEspecializacion.Name = "cmbEspecializacion";
            this.cmbEspecializacion.Size = new System.Drawing.Size(183, 21);
            this.cmbEspecializacion.TabIndex = 20;
            this.cmbEspecializacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecializacion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Veterinario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Especializacion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(202, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 43);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(46, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 43);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DTPHora
            // 
            this.DTPHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPHora.Location = new System.Drawing.Point(116, 240);
            this.DTPHora.Name = "DTPHora";
            this.DTPHora.ShowUpDown = true;
            this.DTPHora.Size = new System.Drawing.Size(230, 20);
            this.DTPHora.TabIndex = 7;
            // 
            // DTPFecha
            // 
            this.DTPFecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DTPFecha.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DTPFecha.Location = new System.Drawing.Point(116, 199);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(230, 20);
            this.DTPFecha.TabIndex = 6;
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Location = new System.Drawing.Point(271, 48);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMascota.TabIndex = 5;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.BackColor = System.Drawing.Color.LightGray;
            this.txtIdMascota.Location = new System.Drawing.Point(163, 22);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.Size = new System.Drawing.Size(183, 20);
            this.txtIdMascota.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(30, 74);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(108, 16);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "NombreMascota";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(30, 26);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(80, 16);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Id Mascota";
            // 
            // FrmCitaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 362);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCitaAgregar";
            this.Text = "FrmCitaAgregar";
            this.Load += new System.EventHandler(this.FrmCitaAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTPHora;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Button btnBuscarMascota;
        private System.Windows.Forms.TextBox txtIdMascota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbVeterianrio;
        private System.Windows.Forms.ComboBox cmbEspecializacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}