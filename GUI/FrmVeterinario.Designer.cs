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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVeterinario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarEspecializacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorEspecialidad = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVeterinario
            // 
            this.DGVeterinario.AllowUserToAddRows = false;
            this.DGVeterinario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVeterinario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVeterinario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVeterinario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVeterinario.ColumnHeadersHeight = 28;
            this.DGVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVeterinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVeterinario.DefaultCellStyle = dataGridViewCellStyle3;
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
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cedula";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IndicateFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(587, 570);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 45);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Veterinario";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            this.bttnActualizar.Location = new System.Drawing.Point(440, 570);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(141, 45);
            this.bttnActualizar.TabIndex = 9;
            this.bttnActualizar.Text = "Actualizar Veterinario";
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
            this.btnGuardar.Location = new System.Drawing.Point(293, 570);
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
            // FrmVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarEspecializacion);
            this.Controls.Add(this.bttnFiltrarPorEspecialidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bttnActualizar);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button bttnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarEspecializacion;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorEspecialidad;
    }
}