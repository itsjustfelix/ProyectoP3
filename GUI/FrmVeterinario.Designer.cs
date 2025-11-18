namespace ProyectoP3
{
    partial class FrmVeterinario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVeterinario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarEspecializacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorEspecialidad = new Guna.UI2.WinForms.Guna2Button();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.elimina = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVeterinario
            // 
            this.DGVeterinario.AllowUserToAddRows = false;
            this.DGVeterinario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVeterinario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVeterinario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVeterinario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVeterinario.ColumnHeadersHeight = 28;
            this.DGVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVeterinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Editar,
            this.elimina});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVeterinario.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVeterinario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVeterinario.Location = new System.Drawing.Point(12, 64);
            this.DGVeterinario.Name = "DGVeterinario";
            this.DGVeterinario.ReadOnly = true;
            this.DGVeterinario.RowHeadersVisible = false;
            this.DGVeterinario.Size = new System.Drawing.Size(1078, 486);
            this.DGVeterinario.TabIndex = 4;
            this.DGVeterinario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVeterinario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVeterinario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVeterinario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVeterinario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVeterinario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVeterinario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVeterinario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVeterinario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVeterinario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVeterinario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVeterinario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVeterinario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVeterinario.ThemeStyle.HeaderStyle.Height = 28;
            this.DGVeterinario.ThemeStyle.ReadOnly = true;
            this.DGVeterinario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVeterinario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVeterinario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVeterinario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVeterinario.ThemeStyle.RowsStyle.Height = 22;
            this.DGVeterinario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVeterinario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVeterinario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVeterinario_CellContentClick);
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
            this.btnGuardar.Location = new System.Drawing.Point(461, 568);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Veterinario";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFiltrarEspecializacion
            // 
            this.txtFiltrarEspecializacion.Animated = true;
            this.txtFiltrarEspecializacion.AutoRoundedCorners = true;
            this.txtFiltrarEspecializacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarEspecializacion.DefaultText = "";
            this.txtFiltrarEspecializacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarEspecializacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarEspecializacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarEspecializacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarEspecializacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarEspecializacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarEspecializacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarEspecializacion.Location = new System.Drawing.Point(12, 12);
            this.txtFiltrarEspecializacion.Name = "txtFiltrarEspecializacion";
            this.txtFiltrarEspecializacion.PlaceholderText = "Filtrar por Especialializacion";
            this.txtFiltrarEspecializacion.SelectedText = "";
            this.txtFiltrarEspecializacion.Size = new System.Drawing.Size(188, 35);
            this.txtFiltrarEspecializacion.TabIndex = 14;
            // 
            // bttnFiltrarPorEspecialidad
            // 
            this.bttnFiltrarPorEspecialidad.Animated = true;
            this.bttnFiltrarPorEspecialidad.AutoRoundedCorners = true;
            this.bttnFiltrarPorEspecialidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFiltrarPorEspecialidad.DefaultAutoSize = true;
            this.bttnFiltrarPorEspecialidad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorEspecialidad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorEspecialidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorEspecialidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorEspecialidad.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorEspecialidad.Location = new System.Drawing.Point(224, 16);
            this.bttnFiltrarPorEspecialidad.Name = "bttnFiltrarPorEspecialidad";
            this.bttnFiltrarPorEspecialidad.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorEspecialidad.TabIndex = 13;
            this.bttnFiltrarPorEspecialidad.Text = "Filtrar";
            this.bttnFiltrarPorEspecialidad.Click += new System.EventHandler(this.bttnFiltrarPorEspecialidad_Click);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nombre";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Apellido Paterno";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Apellido Materno";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Sexo";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Numero Telefonico";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Especializacion";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
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
            this.elimina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarEspecializacion);
            this.Controls.Add(this.bttnFiltrarPorEspecialidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVeterinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVeterinario";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FrmVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVeterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVeterinario;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarEspecializacion;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn elimina;
    }
}