namespace ProyectoP3
{
    partial class FrmVeterinarioEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeterinarioEditar));
            this.label4 = new System.Windows.Forms.Label();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.RBFemenino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.cmbEspecilizacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNumeroTelefonicoPrimario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Especializacion";
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBMasculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMasculino.Location = new System.Drawing.Point(196, 219);
            this.RBMasculino.Margin = new System.Windows.Forms.Padding(4);
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
            this.RBFemenino.Location = new System.Drawing.Point(360, 219);
            this.RBFemenino.Margin = new System.Windows.Forms.Padding(4);
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
            this.label3.Location = new System.Drawing.Point(191, 266);
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
            this.label1.Location = new System.Drawing.Point(191, 192);
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
            // cmbEspecilizacion
            // 
            this.cmbEspecilizacion.AutoRoundedCorners = true;
            this.cmbEspecilizacion.BackColor = System.Drawing.Color.Transparent;
            this.cmbEspecilizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEspecilizacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEspecilizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecilizacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEspecilizacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEspecilizacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEspecilizacion.ForeColor = System.Drawing.Color.Black;
            this.cmbEspecilizacion.ItemHeight = 30;
            this.cmbEspecilizacion.Location = new System.Drawing.Point(196, 374);
            this.cmbEspecilizacion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecilizacion.Name = "cmbEspecilizacion";
            this.cmbEspecilizacion.Size = new System.Drawing.Size(299, 36);
            this.cmbEspecilizacion.TabIndex = 62;
            // 
            // txtNumeroTelefonicoPrimario
            // 
            this.txtNumeroTelefonicoPrimario.Animated = true;
            this.txtNumeroTelefonicoPrimario.AutoRoundedCorners = true;
            this.txtNumeroTelefonicoPrimario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTelefonicoPrimario.DefaultText = "";
            this.txtNumeroTelefonicoPrimario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroTelefonicoPrimario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroTelefonicoPrimario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTelefonicoPrimario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroTelefonicoPrimario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTelefonicoPrimario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumeroTelefonicoPrimario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroTelefonicoPrimario.Location = new System.Drawing.Point(196, 293);
            this.txtNumeroTelefonicoPrimario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroTelefonicoPrimario.Name = "txtNumeroTelefonicoPrimario";
            this.txtNumeroTelefonicoPrimario.PlaceholderText = "";
            this.txtNumeroTelefonicoPrimario.SelectedText = "";
            this.txtNumeroTelefonicoPrimario.Size = new System.Drawing.Size(300, 44);
            this.txtNumeroTelefonicoPrimario.TabIndex = 60;
            this.txtNumeroTelefonicoPrimario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefonicoPrimario_KeyPress);
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
            this.txtNombre.TabIndex = 58;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Animated = true;
            this.txtCedula.AutoRoundedCorners = true;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.DefaultText = "";
            this.txtCedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCedula.Enabled = false;
            this.txtCedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCedula.Location = new System.Drawing.Point(196, 60);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PlaceholderText = "";
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(300, 44);
            this.txtCedula.TabIndex = 57;
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
            this.btnEditar.Location = new System.Drawing.Point(125, 435);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 55);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
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
            this.btnCancelar.Location = new System.Drawing.Point(360, 435);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 55);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmVeterinarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(691, 517);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbEspecilizacion);
            this.Controls.Add(this.txtNumeroTelefonicoPrimario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RBMasculino);
            this.Controls.Add(this.RBFemenino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVeterinarioEditar";
            this.Text = "FrmVeterinarioEditar";
            this.Load += new System.EventHandler(this.FrmVeterinarioEditar_Load);
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
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEspecilizacion;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroTelefonicoPrimario;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtCedula;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}