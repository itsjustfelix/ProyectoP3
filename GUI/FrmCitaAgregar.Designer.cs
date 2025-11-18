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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.txtCedulaPropietario = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbEspecializacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbVeterianrio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.DTPFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DTPHora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNombrePropietario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMascotas = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBuscarMascota = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Veterinario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Especializacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(123, 17);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(154, 19);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Cedula Propietario";
            // 
            // txtCedulaPropietario
            // 
            this.txtCedulaPropietario.Animated = true;
            this.txtCedulaPropietario.AutoRoundedCorners = true;
            this.txtCedulaPropietario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedulaPropietario.DefaultText = "";
            this.txtCedulaPropietario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedulaPropietario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedulaPropietario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedulaPropietario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedulaPropietario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedulaPropietario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPropietario.ForeColor = System.Drawing.Color.Black;
            this.txtCedulaPropietario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedulaPropietario.Location = new System.Drawing.Point(127, 40);
            this.txtCedulaPropietario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedulaPropietario.Name = "txtCedulaPropietario";
            this.txtCedulaPropietario.PlaceholderText = "";
            this.txtCedulaPropietario.SelectedText = "";
            this.txtCedulaPropietario.Size = new System.Drawing.Size(269, 31);
            this.txtCedulaPropietario.TabIndex = 24;
            // 
            // cmbEspecializacion
            // 
            this.cmbEspecializacion.AutoRoundedCorners = true;
            this.cmbEspecializacion.BackColor = System.Drawing.Color.Transparent;
            this.cmbEspecializacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEspecializacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEspecializacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecializacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEspecializacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEspecializacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecializacion.ForeColor = System.Drawing.Color.Black;
            this.cmbEspecializacion.ItemHeight = 30;
            this.cmbEspecializacion.Location = new System.Drawing.Point(127, 200);
            this.cmbEspecializacion.Name = "cmbEspecializacion";
            this.cmbEspecializacion.Size = new System.Drawing.Size(269, 36);
            this.cmbEspecializacion.TabIndex = 25;
            this.cmbEspecializacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecializacion_SelectedIndexChanged_1);
            // 
            // cmbVeterianrio
            // 
            this.cmbVeterianrio.AutoRoundedCorners = true;
            this.cmbVeterianrio.BackColor = System.Drawing.Color.Transparent;
            this.cmbVeterianrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVeterianrio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVeterianrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeterianrio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVeterianrio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVeterianrio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeterianrio.ForeColor = System.Drawing.Color.Black;
            this.cmbVeterianrio.ItemHeight = 30;
            this.cmbVeterianrio.Location = new System.Drawing.Point(127, 272);
            this.cmbVeterianrio.Name = "cmbVeterianrio";
            this.cmbVeterianrio.Size = new System.Drawing.Size(269, 36);
            this.cmbVeterianrio.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(298, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 45);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Animated = true;
            this.btnAgregar.AutoRoundedCorners = true;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(95, 442);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 45);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Animated = true;
            this.DTPFecha.AutoRoundedCorners = true;
            this.DTPFecha.Checked = true;
            this.DTPFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPFecha.FillColor = System.Drawing.Color.White;
            this.DTPFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPFecha.Location = new System.Drawing.Point(127, 333);
            this.DTPFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(269, 36);
            this.DTPFecha.TabIndex = 29;
            this.DTPFecha.Value = new System.DateTime(2025, 11, 11, 12, 13, 43, 226);
            // 
            // DTPHora
            // 
            this.DTPHora.Animated = true;
            this.DTPHora.AutoRoundedCorners = true;
            this.DTPHora.Checked = true;
            this.DTPHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPHora.FillColor = System.Drawing.Color.White;
            this.DTPHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTPHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPHora.Location = new System.Drawing.Point(127, 400);
            this.DTPHora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPHora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPHora.Name = "DTPHora";
            this.DTPHora.ShowUpDown = true;
            this.DTPHora.Size = new System.Drawing.Size(269, 36);
            this.DTPHora.TabIndex = 30;
            this.DTPHora.Value = new System.DateTime(2025, 11, 11, 12, 13, 43, 226);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.guna2Panel1.Controls.Add(this.lblNombrePropietario);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.cmbMascotas);
            this.guna2Panel1.Controls.Add(this.btnBuscarMascota);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.nombre);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.txtCedulaPropietario);
            this.guna2Panel1.Controls.Add(this.cmbEspecializacion);
            this.guna2Panel1.Controls.Add(this.cmbVeterianrio);
            this.guna2Panel1.Controls.Add(this.btnAgregar);
            this.guna2Panel1.Controls.Add(this.btnCancelar);
            this.guna2Panel1.Controls.Add(this.DTPFecha);
            this.guna2Panel1.Controls.Add(this.DTPHora);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(539, 500);
            this.guna2Panel1.TabIndex = 31;
            // 
            // lblNombrePropietario
            // 
            this.lblNombrePropietario.AutoSize = true;
            this.lblNombrePropietario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePropietario.Location = new System.Drawing.Point(123, 75);
            this.lblNombrePropietario.Name = "lblNombrePropietario";
            this.lblNombrePropietario.Size = new System.Drawing.Size(158, 19);
            this.lblNombrePropietario.TabIndex = 34;
            this.lblNombrePropietario.Text = "nombre Propietario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mascotas";
            // 
            // cmbMascotas
            // 
            this.cmbMascotas.AutoRoundedCorners = true;
            this.cmbMascotas.BackColor = System.Drawing.Color.Transparent;
            this.cmbMascotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMascotas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMascotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMascotas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMascotas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMascotas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMascotas.ForeColor = System.Drawing.Color.Black;
            this.cmbMascotas.ItemHeight = 30;
            this.cmbMascotas.Location = new System.Drawing.Point(127, 139);
            this.cmbMascotas.Name = "cmbMascotas";
            this.cmbMascotas.Size = new System.Drawing.Size(269, 36);
            this.cmbMascotas.TabIndex = 32;
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.Animated = true;
            this.btnBuscarMascota.AutoRoundedCorners = true;
            this.btnBuscarMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMascota.DefaultAutoSize = true;
            this.btnBuscarMascota.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMascota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarMascota.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMascota.Location = new System.Drawing.Point(415, 42);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(65, 27);
            this.btnBuscarMascota.TabIndex = 31;
            this.btnBuscarMascota.Text = "Buscar";
            this.btnBuscarMascota.Click += new System.EventHandler(this.btnBuscarMascota_Click_1);
            // 
            // FrmCitaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 500);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCitaAgregar";
            this.Text = "FrmCitaAgregar";
            this.Load += new System.EventHandler(this.FrmCitaAgregar_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCedulaPropietario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEspecializacion;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVeterianrio;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPFecha;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPHora;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnBuscarMascota;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMascotas;
        private System.Windows.Forms.Label lblNombrePropietario;
    }
}