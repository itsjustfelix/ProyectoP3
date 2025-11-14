namespace ProyectoP3
{
    partial class FrmMascota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVMascota = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnFiltrarPorEspecie = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarEspecie = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltrarRaza = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorRaza = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarPropietario = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorPropietario = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMascota
            // 
            this.DGVMascota.AllowUserToAddRows = false;
            this.DGVMascota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVMascota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMascota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMascota.ColumnHeadersHeight = 15;
            this.DGVMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMascota.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVMascota.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVMascota.Location = new System.Drawing.Point(12, 55);
            this.DGVMascota.Name = "DGVMascota";
            this.DGVMascota.ReadOnly = true;
            this.DGVMascota.RowHeadersVisible = false;
            this.DGVMascota.Size = new System.Drawing.Size(1078, 515);
            this.DGVMascota.TabIndex = 4;
            this.DGVMascota.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVMascota.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVMascota.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVMascota.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVMascota.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVMascota.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVMascota.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVMascota.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVMascota.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVMascota.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVMascota.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVMascota.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVMascota.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVMascota.ThemeStyle.HeaderStyle.Height = 15;
            this.DGVMascota.ThemeStyle.ReadOnly = true;
            this.DGVMascota.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVMascota.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVMascota.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVMascota.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVMascota.ThemeStyle.RowsStyle.Height = 22;
            this.DGVMascota.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVMascota.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Especie";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Raza";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Propietario";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.AutoRoundedCorners = true;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IndicateFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(593, 587);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 45);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar Mascota";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.Animated = true;
            this.bttnActualizar.AutoRoundedCorners = true;
            this.bttnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.bttnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.ForeColor = System.Drawing.Color.Black;
            this.bttnActualizar.IndicateFocus = true;
            this.bttnActualizar.Location = new System.Drawing.Point(446, 587);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(141, 45);
            this.bttnActualizar.TabIndex = 18;
            this.bttnActualizar.Text = "Actualizar Mascota";
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(299, 587);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Mascota";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bttnFiltrarPorEspecie
            // 
            this.bttnFiltrarPorEspecie.Animated = true;
            this.bttnFiltrarPorEspecie.AutoRoundedCorners = true;
            this.bttnFiltrarPorEspecie.DefaultAutoSize = true;
            this.bttnFiltrarPorEspecie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorEspecie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorEspecie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorEspecie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorEspecie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorEspecie.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorEspecie.Location = new System.Drawing.Point(218, 17);
            this.bttnFiltrarPorEspecie.Name = "bttnFiltrarPorEspecie";
            this.bttnFiltrarPorEspecie.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorEspecie.TabIndex = 20;
            this.bttnFiltrarPorEspecie.Text = "Filtrar";
            this.bttnFiltrarPorEspecie.Click += new System.EventHandler(this.bttnFiltrarPorEspecie_Click);
            // 
            // txtFiltrarEspecie
            // 
            this.txtFiltrarEspecie.Animated = true;
            this.txtFiltrarEspecie.AutoRoundedCorners = true;
            this.txtFiltrarEspecie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarEspecie.DefaultText = "";
            this.txtFiltrarEspecie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarEspecie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarEspecie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarEspecie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarEspecie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarEspecie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarEspecie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarEspecie.Location = new System.Drawing.Point(12, 12);
            this.txtFiltrarEspecie.Name = "txtFiltrarEspecie";
            this.txtFiltrarEspecie.PlaceholderText = "Filtrar Por Especie";
            this.txtFiltrarEspecie.SelectedText = "";
            this.txtFiltrarEspecie.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarEspecie.TabIndex = 21;
            // 
            // txtFiltrarRaza
            // 
            this.txtFiltrarRaza.Animated = true;
            this.txtFiltrarRaza.AutoRoundedCorners = true;
            this.txtFiltrarRaza.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarRaza.DefaultText = "";
            this.txtFiltrarRaza.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarRaza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarRaza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarRaza.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarRaza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarRaza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarRaza.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarRaza.Location = new System.Drawing.Point(416, 12);
            this.txtFiltrarRaza.Name = "txtFiltrarRaza";
            this.txtFiltrarRaza.PlaceholderText = "Filtrar Por Raza";
            this.txtFiltrarRaza.SelectedText = "";
            this.txtFiltrarRaza.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarRaza.TabIndex = 23;
            // 
            // bttnFiltrarPorRaza
            // 
            this.bttnFiltrarPorRaza.Animated = true;
            this.bttnFiltrarPorRaza.AutoRoundedCorners = true;
            this.bttnFiltrarPorRaza.DefaultAutoSize = true;
            this.bttnFiltrarPorRaza.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorRaza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorRaza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorRaza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorRaza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorRaza.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorRaza.Location = new System.Drawing.Point(622, 17);
            this.bttnFiltrarPorRaza.Name = "bttnFiltrarPorRaza";
            this.bttnFiltrarPorRaza.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorRaza.TabIndex = 22;
            this.bttnFiltrarPorRaza.Text = "Filtrar";
            this.bttnFiltrarPorRaza.Click += new System.EventHandler(this.bttnFiltrarPorRaza_Click);
            // 
            // txtFiltrarPropietario
            // 
            this.txtFiltrarPropietario.Animated = true;
            this.txtFiltrarPropietario.AutoRoundedCorners = true;
            this.txtFiltrarPropietario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarPropietario.DefaultText = "";
            this.txtFiltrarPropietario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarPropietario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarPropietario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPropietario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPropietario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPropietario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarPropietario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPropietario.Location = new System.Drawing.Point(821, 12);
            this.txtFiltrarPropietario.Name = "txtFiltrarPropietario";
            this.txtFiltrarPropietario.PlaceholderText = "Filtrar Por Propietario";
            this.txtFiltrarPropietario.SelectedText = "";
            this.txtFiltrarPropietario.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarPropietario.TabIndex = 25;
            // 
            // bttnFiltrarPorPropietario
            // 
            this.bttnFiltrarPorPropietario.Animated = true;
            this.bttnFiltrarPorPropietario.AutoRoundedCorners = true;
            this.bttnFiltrarPorPropietario.DefaultAutoSize = true;
            this.bttnFiltrarPorPropietario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorPropietario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorPropietario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorPropietario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorPropietario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorPropietario.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorPropietario.Location = new System.Drawing.Point(1027, 17);
            this.bttnFiltrarPorPropietario.Name = "bttnFiltrarPorPropietario";
            this.bttnFiltrarPorPropietario.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorPropietario.TabIndex = 24;
            this.bttnFiltrarPorPropietario.Text = "Filtrar";
            this.bttnFiltrarPorPropietario.Click += new System.EventHandler(this.bttnFiltrarPorPropietario_Click);
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarPropietario);
            this.Controls.Add(this.bttnFiltrarPorPropietario);
            this.Controls.Add(this.txtFiltrarRaza);
            this.Controls.Add(this.bttnFiltrarPorRaza);
            this.Controls.Add(this.txtFiltrarEspecie);
            this.Controls.Add(this.bttnFiltrarPorEspecie);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMascota";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button bttnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorEspecie;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarEspecie;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarRaza;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorRaza;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPropietario;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorPropietario;
    }
}