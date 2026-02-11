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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropietarioAgregar));
            this.label7 = new System.Windows.Forms.Label();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.RBFemenino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumeroTelefonoPrimario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email";
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBMasculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMasculino.Location = new System.Drawing.Point(196, 218);
            this.RBMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBMasculino.Name = "RBMasculino";
            this.RBMasculino.Size = new System.Drawing.Size(125, 27);
            this.RBMasculino.TabIndex = 10;
            this.RBMasculino.TabStop = true;
            this.RBMasculino.Text = "Masculino";
            this.RBMasculino.UseVisualStyleBackColor = true;
            // 
            // RBFemenino
            // 
            this.RBFemenino.AutoSize = true;
            this.RBFemenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBFemenino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFemenino.Location = new System.Drawing.Point(375, 218);
            this.RBFemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBFemenino.Name = "RBFemenino";
            this.RBFemenino.Size = new System.Drawing.Size(121, 27);
            this.RBFemenino.TabIndex = 11;
            this.RBFemenino.TabStop = true;
            this.RBFemenino.Text = "Femenino";
            this.RBFemenino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero Telefonico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cedula";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(191, 108);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(98, 23);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "Nombres";
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
            this.btnCancelar.IndicateFocus = true;
            this.btnCancelar.Location = new System.Drawing.Point(360, 434);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 53);
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
            this.txtEmail.Location = new System.Drawing.Point(196, 373);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(300, 44);
            this.txtEmail.TabIndex = 46;
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
            this.txtNumeroTelefonoPrimario.Location = new System.Drawing.Point(196, 292);
            this.txtNumeroTelefonoPrimario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroTelefonoPrimario.Name = "txtNumeroTelefonoPrimario";
            this.txtNumeroTelefonoPrimario.PlaceholderText = "";
            this.txtNumeroTelefonoPrimario.SelectedText = "";
            this.txtNumeroTelefonoPrimario.Size = new System.Drawing.Size(300, 44);
            this.txtNumeroTelefonoPrimario.TabIndex = 44;
            this.txtNumeroTelefonoPrimario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefonoPrimario_KeyPress);
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
            this.txtId.Location = new System.Drawing.Point(196, 60);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(300, 44);
            this.txtId.TabIndex = 42;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
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
            this.txtNombre.Location = new System.Drawing.Point(196, 135);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(300, 44);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.btnAgregar.IndicateFocus = true;
            this.btnAgregar.Location = new System.Drawing.Point(125, 434);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(191, 53);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmPropietarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(691, 517);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumeroTelefonoPrimario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RBMasculino);
            this.Controls.Add(this.RBFemenino);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPropietarioAgregar";
            this.Text = "FrmAgregarPropietario";
            this.Load += new System.EventHandler(this.FrmPropietarioAgregar_Load);
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
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroTelefonoPrimario;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}