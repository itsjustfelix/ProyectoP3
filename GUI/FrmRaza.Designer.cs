namespace ProyectoP3
{
    partial class FrmRaza
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
            this.DGVRaza = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bttnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnFiltrarPorNombre = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltrarEspecie = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarEspecie = new Guna.UI2.WinForms.Guna2Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.elimina = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRaza)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRaza
            // 
            this.DGVRaza.AllowUserToAddRows = false;
            this.DGVRaza.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVRaza.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRaza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRaza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRaza.ColumnHeadersHeight = 15;
            this.DGVRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVRaza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column5,
            this.Column6,
            this.Editar,
            this.elimina});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRaza.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRaza.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVRaza.Location = new System.Drawing.Point(12, 57);
            this.DGVRaza.Name = "DGVRaza";
            this.DGVRaza.ReadOnly = true;
            this.DGVRaza.RowHeadersVisible = false;
            this.DGVRaza.Size = new System.Drawing.Size(1078, 501);
            this.DGVRaza.TabIndex = 4;
            this.DGVRaza.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVRaza.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVRaza.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVRaza.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVRaza.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVRaza.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVRaza.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVRaza.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVRaza.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVRaza.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVRaza.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRaza.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVRaza.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVRaza.ThemeStyle.HeaderStyle.Height = 15;
            this.DGVRaza.ThemeStyle.ReadOnly = true;
            this.DGVRaza.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVRaza.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVRaza.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRaza.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVRaza.ThemeStyle.RowsStyle.Height = 22;
            this.DGVRaza.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVRaza.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVRaza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRaza_CellContentClick);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.Animated = true;
            this.bttnActualizar.AutoRoundedCorners = true;
            this.bttnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnActualizar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.bttnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.ForeColor = System.Drawing.Color.Black;
            this.bttnActualizar.IndicateFocus = true;
            this.bttnActualizar.Location = new System.Drawing.Point(469, 576);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(141, 45);
            this.bttnActualizar.TabIndex = 15;
            this.bttnActualizar.Text = "Actualizar Raza";
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(322, 576);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar Raza";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.AutoRoundedCorners = true;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IndicateFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(616, 576);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 45);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Raza";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // bttnFiltrarPorNombre
            // 
            this.bttnFiltrarPorNombre.Animated = true;
            this.bttnFiltrarPorNombre.AutoRoundedCorners = true;
            this.bttnFiltrarPorNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFiltrarPorNombre.DefaultAutoSize = true;
            this.bttnFiltrarPorNombre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorNombre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorNombre.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorNombre.Location = new System.Drawing.Point(249, 17);
            this.bttnFiltrarPorNombre.Name = "bttnFiltrarPorNombre";
            this.bttnFiltrarPorNombre.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorNombre.TabIndex = 17;
            this.bttnFiltrarPorNombre.Text = "Filtrar";
            this.bttnFiltrarPorNombre.Click += new System.EventHandler(this.bttnFiltrarPorNombre_Click);
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.Animated = true;
            this.txtFiltrarNombre.AutoRoundedCorners = true;
            this.txtFiltrarNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarNombre.DefaultText = "";
            this.txtFiltrarNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarNombre.Location = new System.Drawing.Point(12, 12);
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.PlaceholderText = "Filtrar por Nombre";
            this.txtFiltrarNombre.SelectedText = "";
            this.txtFiltrarNombre.Size = new System.Drawing.Size(231, 36);
            this.txtFiltrarNombre.TabIndex = 18;
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
            this.txtFiltrarEspecie.Location = new System.Drawing.Point(780, 12);
            this.txtFiltrarEspecie.Name = "txtFiltrarEspecie";
            this.txtFiltrarEspecie.PlaceholderText = "Filtrar por Especie";
            this.txtFiltrarEspecie.SelectedText = "";
            this.txtFiltrarEspecie.Size = new System.Drawing.Size(231, 36);
            this.txtFiltrarEspecie.TabIndex = 20;
            // 
            // bttnFiltrarEspecie
            // 
            this.bttnFiltrarEspecie.Animated = true;
            this.bttnFiltrarEspecie.AutoRoundedCorners = true;
            this.bttnFiltrarEspecie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFiltrarEspecie.DefaultAutoSize = true;
            this.bttnFiltrarEspecie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarEspecie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarEspecie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarEspecie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarEspecie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarEspecie.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarEspecie.Location = new System.Drawing.Point(1017, 17);
            this.bttnFiltrarEspecie.Name = "bttnFiltrarEspecie";
            this.bttnFiltrarEspecie.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarEspecie.TabIndex = 19;
            this.bttnFiltrarEspecie.Text = "Filtrar";
            this.bttnFiltrarEspecie.Click += new System.EventHandler(this.bttnFiltrarEspecie_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Raza";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoP3.Properties.Resources.MaterialSymbolsEdit__4_;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // elimina
            // 
            this.elimina.HeaderText = "Eliminar";
            this.elimina.Image = global::ProyectoP3.Properties.Resources.LetsIconsDelAltFill__1_;
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
            // 
            // FrmRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarEspecie);
            this.Controls.Add(this.bttnFiltrarEspecie);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.bttnFiltrarPorNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVRaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaza";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FrmRaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVRaza;
        private Guna.UI2.WinForms.Guna2Button bttnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarEspecie;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn elimina;
    }
}