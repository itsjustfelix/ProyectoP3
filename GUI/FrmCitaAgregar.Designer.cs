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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTPHora = new System.Windows.Forms.DateTimePicker();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarMascota = new System.Windows.Forms.Button();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 285);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // DTPHora
            // 
            this.DTPHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPHora.Location = new System.Drawing.Point(73, 171);
            this.DTPHora.Name = "DTPHora";
            this.DTPHora.ShowUpDown = true;
            this.DTPHora.Size = new System.Drawing.Size(230, 20);
            this.DTPHora.TabIndex = 7;
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(73, 122);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(230, 20);
            this.DTPFecha.TabIndex = 6;
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Location = new System.Drawing.Point(228, 43);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMascota.TabIndex = 5;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.UseVisualStyleBackColor = true;
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Location = new System.Drawing.Point(120, 17);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.Size = new System.Drawing.Size(183, 20);
            this.txtIdMascota.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(30, 67);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(108, 16);
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
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(155, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(30, 234);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 33);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmCitaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
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
    }
}