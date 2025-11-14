namespace ProyectoP3
{
    partial class FrmcitaEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmcitaEditar));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.DTPHora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DTPFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbVeterinario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbEspecializacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIdMascota = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Especializacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Veterinario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(123, 97);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(139, 19);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "NombreMascota";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(123, 30);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(137, 19);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Codigo Mascota";
            // 
            // DTPHora
            // 
            this.DTPHora.Animated = true;
            this.DTPHora.AutoRoundedCorners = true;
            this.DTPHora.Checked = true;
            this.DTPHora.FillColor = System.Drawing.Color.White;
            this.DTPHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTPHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPHora.Location = new System.Drawing.Point(127, 378);
            this.DTPHora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPHora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPHora.Name = "DTPHora";
            this.DTPHora.Size = new System.Drawing.Size(269, 36);
            this.DTPHora.TabIndex = 44;
            this.DTPHora.Value = new System.DateTime(2025, 11, 11, 12, 13, 43, 226);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Animated = true;
            this.DTPFecha.AutoRoundedCorners = true;
            this.DTPFecha.Checked = true;
            this.DTPFecha.FillColor = System.Drawing.Color.White;
            this.DTPFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPFecha.Location = new System.Drawing.Point(127, 311);
            this.DTPFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(269, 36);
            this.DTPFecha.TabIndex = 43;
            this.DTPFecha.Value = new System.DateTime(2025, 11, 11, 12, 13, 43, 226);
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
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Animated = true;
            this.btnEditar.AutoRoundedCorners = true;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(95, 442);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 45);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // cmbVeterinario
            // 
            this.cmbVeterinario.AutoRoundedCorners = true;
            this.cmbVeterinario.BackColor = System.Drawing.Color.Transparent;
            this.cmbVeterinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVeterinario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeterinario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVeterinario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbVeterinario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeterinario.ForeColor = System.Drawing.Color.Black;
            this.cmbVeterinario.ItemHeight = 30;
            this.cmbVeterinario.Location = new System.Drawing.Point(127, 250);
            this.cmbVeterinario.Name = "cmbVeterinario";
            this.cmbVeterinario.Size = new System.Drawing.Size(269, 36);
            this.cmbVeterinario.TabIndex = 40;
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
            this.cmbEspecializacion.Location = new System.Drawing.Point(127, 178);
            this.cmbEspecializacion.Name = "cmbEspecializacion";
            this.cmbEspecializacion.Size = new System.Drawing.Size(269, 36);
            this.cmbEspecializacion.TabIndex = 39;
            this.cmbEspecializacion.SelectedIndexChanged += new System.EventHandler(this.cmbEspecializacion_SelectedIndexChanged_1);
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Animated = true;
            this.txtIdMascota.AutoRoundedCorners = true;
            this.txtIdMascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdMascota.DefaultText = "";
            this.txtIdMascota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdMascota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdMascota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMascota.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMascota.ForeColor = System.Drawing.Color.Black;
            this.txtIdMascota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMascota.Location = new System.Drawing.Point(127, 53);
            this.txtIdMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.PlaceholderText = "";
            this.txtIdMascota.SelectedText = "";
            this.txtIdMascota.Size = new System.Drawing.Size(269, 31);
            this.txtIdMascota.TabIndex = 38;
            // 
            // FrmcitaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(539, 500);
            this.Controls.Add(this.DTPHora);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbVeterinario);
            this.Controls.Add(this.cmbEspecializacion);
            this.Controls.Add(this.txtIdMascota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.lblNombreMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmcitaEditar";
            this.Text = "FrmcitaEditar";
            this.Load += new System.EventHandler(this.FrmcitaEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPHora;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPFecha;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbVeterinario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEspecializacion;
        private Guna.UI2.WinForms.Guna2TextBox txtIdMascota;
    }
}