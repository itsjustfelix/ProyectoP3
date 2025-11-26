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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVMascota = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.elimina = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarEspecie = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMascota
            // 
            this.DGVMascota.AllowUserToAddRows = false;
            this.DGVMascota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVMascota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVMascota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMascota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVMascota.ColumnHeadersHeight = 15;
            this.DGVMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Editar,
            this.elimina});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMascota.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVMascota.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVMascota.Location = new System.Drawing.Point(12, 57);
            this.DGVMascota.Name = "DGVMascota";
            this.DGVMascota.ReadOnly = true;
            this.DGVMascota.RowHeadersVisible = false;
            this.DGVMascota.Size = new System.Drawing.Size(1074, 556);
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
            this.DGVMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMascota_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
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
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ProyectoP3.Properties.Resources.MaterialSymbolsEdit__4_;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // elimina
            // 
            this.elimina.HeaderText = "Eliminar";
            this.elimina.Image = global::ProyectoP3.Properties.Resources.LetsIconsDelAltFill__1_;
            this.elimina.Name = "elimina";
            this.elimina.ReadOnly = true;
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
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(512, 633);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Agregar Mascota";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.txtFiltrarEspecie.PlaceholderText = "Filtrar";
            this.txtFiltrarEspecie.SelectedText = "";
            this.txtFiltrarEspecie.Size = new System.Drawing.Size(231, 36);
            this.txtFiltrarEspecie.TabIndex = 21;
            this.txtFiltrarEspecie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltrarEspecie_KeyDown);
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarEspecie);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMascota";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVMascota;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn elimina;
    }
}