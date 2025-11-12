namespace ProyectoP3
{
    partial class FrmPropietarioAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropietarioAgregar));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.RBFemenino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellidoMaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumeroTelefonoPrimario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellidoPaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido Paterno";
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMasculino.Location = new System.Drawing.Point(259, 250);
            this.RBMasculino.Name = "RBMasculino";
            this.RBMasculino.Size = new System.Drawing.Size(102, 22);
            this.RBMasculino.TabIndex = 10;
            this.RBMasculino.TabStop = true;
            this.RBMasculino.Text = "Masculino";
            this.RBMasculino.UseVisualStyleBackColor = true;
            this.RBMasculino.CheckedChanged += new System.EventHandler(this.RBMasculino_CheckedChanged);
            // 
            // RBFemenino
            // 
            this.RBFemenino.AutoSize = true;
            this.RBFemenino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFemenino.Location = new System.Drawing.Point(380, 250);
            this.RBFemenino.Name = "RBFemenino";
            this.RBFemenino.Size = new System.Drawing.Size(99, 22);
            this.RBFemenino.TabIndex = 11;
            this.RBFemenino.TabStop = true;
            this.RBFemenino.Text = "Femenino";
            this.RBFemenino.UseVisualStyleBackColor = true;
            this.RBFemenino.CheckedChanged += new System.EventHandler(this.RBFemenino_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero Telefonico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cedula";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(60, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(79, 19);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "Nombres";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(285, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 45);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(259, 363);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(220, 36);
            this.txtEmail.TabIndex = 46;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Animated = true;
            this.txtApellidoMaterno.AutoRoundedCorners = true;
            this.txtApellidoMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoMaterno.DefaultText = "";
            this.txtApellidoMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidoMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(259, 194);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.PlaceholderText = "";
            this.txtApellidoMaterno.SelectedText = "";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(220, 40);
            this.txtApellidoMaterno.TabIndex = 45;
            // 
            // txtNumeroTelefonoPrimario
            // 
            this.txtNumeroTelefonoPrimario.Animated = true;
            this.txtNumeroTelefonoPrimario.AutoRoundedCorners = true;
            this.txtNumeroTelefonoPrimario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTelefonoPrimario.DefaultText = "";
            this.txtNumeroTelefonoPrimario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroTelefonoPrimario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroTelefonoPrimario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTelefonoPrimario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTelefonoPrimario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTelefonoPrimario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumeroTelefonoPrimario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTelefonoPrimario.Location = new System.Drawing.Point(259, 302);
            this.txtNumeroTelefonoPrimario.Name = "txtNumeroTelefonoPrimario";
            this.txtNumeroTelefonoPrimario.PlaceholderText = "";
            this.txtNumeroTelefonoPrimario.SelectedText = "";
            this.txtNumeroTelefonoPrimario.Size = new System.Drawing.Size(220, 41);
            this.txtNumeroTelefonoPrimario.TabIndex = 44;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Animated = true;
            this.txtApellidoPaterno.AutoRoundedCorners = true;
            this.txtApellidoPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPaterno.DefaultText = "";
            this.txtApellidoPaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoPaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoPaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidoPaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(259, 129);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.PlaceholderText = "";
            this.txtApellidoPaterno.SelectedText = "";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(220, 43);
            this.txtApellidoPaterno.TabIndex = 43;
            // 
            // txtId
            // 
            this.txtId.Animated = true;
            this.txtId.AutoRoundedCorners = true;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(254, 12);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(225, 36);
            this.txtId.TabIndex = 42;
            // 
            // txtNombre
            // 
            this.txtNombre.Animated = true;
            this.txtNombre.AutoRoundedCorners = true;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(254, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(225, 36);
            this.txtNombre.TabIndex = 41;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Animated = true;
            this.btnAgregar.AutoRoundedCorners = true;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(109, 430);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 45);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // FrmPropietarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 498);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtNumeroTelefonoPrimario);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RBMasculino);
            this.Controls.Add(this.RBFemenino);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmPropietarioAgregar";
            this.Text = "FrmAgregarPropietario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RBMasculino;
        private System.Windows.Forms.RadioButton RBFemenino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoMaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroTelefonoPrimario;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoPaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
    }
}