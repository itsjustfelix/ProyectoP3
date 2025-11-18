namespace ProyectoP3
{
    partial class FrmCita
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
            this.DGVCita = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarPorVeterinario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltrarPorFacha = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorFecha = new Guna.UI2.WinForms.Guna2Button();
            this.bttnFiltrarPorVeterinario = new Guna.UI2.WinForms.Guna2Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.elimina = new System.Windows.Forms.DataGridViewImageColumn();
            this.AtenderCita = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCita)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCita
            // 
            this.DGVCita.AllowUserToAddRows = false;
            this.DGVCita.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVCita.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCita.ColumnHeadersHeight = 15;
            this.DGVCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Editar,
            this.elimina,
            this.AtenderCita});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCita.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCita.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVCita.Location = new System.Drawing.Point(12, 77);
            this.DGVCita.Name = "DGVCita";
            this.DGVCita.ReadOnly = true;
            this.DGVCita.RowHeadersVisible = false;
            this.DGVCita.Size = new System.Drawing.Size(1078, 492);
            this.DGVCita.TabIndex = 4;
            this.DGVCita.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVCita.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVCita.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVCita.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVCita.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVCita.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVCita.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVCita.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVCita.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVCita.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCita.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCita.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVCita.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVCita.ThemeStyle.HeaderStyle.Height = 15;
            this.DGVCita.ThemeStyle.ReadOnly = true;
            this.DGVCita.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVCita.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCita.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCita.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVCita.ThemeStyle.RowsStyle.Height = 22;
            this.DGVCita.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVCita.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCita_CellContentClick);
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
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(445, 575);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Cita";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFiltrarPorVeterinario
            // 
            this.txtFiltrarPorVeterinario.Animated = true;
            this.txtFiltrarPorVeterinario.AutoRoundedCorners = true;
            this.txtFiltrarPorVeterinario.BorderColor = System.Drawing.Color.White;
            this.txtFiltrarPorVeterinario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarPorVeterinario.DefaultText = "";
            this.txtFiltrarPorVeterinario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarPorVeterinario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarPorVeterinario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorVeterinario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorVeterinario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorVeterinario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarPorVeterinario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorVeterinario.Location = new System.Drawing.Point(12, 21);
            this.txtFiltrarPorVeterinario.Name = "txtFiltrarPorVeterinario";
            this.txtFiltrarPorVeterinario.PlaceholderText = "Filtrar por veterinario";
            this.txtFiltrarPorVeterinario.SelectedText = "";
            this.txtFiltrarPorVeterinario.Size = new System.Drawing.Size(272, 38);
            this.txtFiltrarPorVeterinario.TabIndex = 21;
            // 
            // txtFiltrarPorFacha
            // 
            this.txtFiltrarPorFacha.Animated = true;
            this.txtFiltrarPorFacha.AutoRoundedCorners = true;
            this.txtFiltrarPorFacha.BorderColor = System.Drawing.Color.White;
            this.txtFiltrarPorFacha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarPorFacha.DefaultText = "";
            this.txtFiltrarPorFacha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarPorFacha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarPorFacha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorFacha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorFacha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorFacha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarPorFacha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorFacha.Location = new System.Drawing.Point(661, 21);
            this.txtFiltrarPorFacha.Name = "txtFiltrarPorFacha";
            this.txtFiltrarPorFacha.PlaceholderText = "Filtrar por fecha";
            this.txtFiltrarPorFacha.SelectedText = "";
            this.txtFiltrarPorFacha.Size = new System.Drawing.Size(272, 38);
            this.txtFiltrarPorFacha.TabIndex = 22;
            // 
            // bttnFiltrarPorFecha
            // 
            this.bttnFiltrarPorFecha.Animated = true;
            this.bttnFiltrarPorFecha.AutoRoundedCorners = true;
            this.bttnFiltrarPorFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFiltrarPorFecha.DefaultAutoSize = true;
            this.bttnFiltrarPorFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorFecha.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorFecha.Location = new System.Drawing.Point(957, 27);
            this.bttnFiltrarPorFecha.Name = "bttnFiltrarPorFecha";
            this.bttnFiltrarPorFecha.Size = new System.Drawing.Size(65, 27);
            this.bttnFiltrarPorFecha.TabIndex = 24;
            this.bttnFiltrarPorFecha.Text = "Buscar";
            this.bttnFiltrarPorFecha.Click += new System.EventHandler(this.bttnFiltrarPorFecha_Click);
            // 
            // bttnFiltrarPorVeterinario
            // 
            this.bttnFiltrarPorVeterinario.Animated = true;
            this.bttnFiltrarPorVeterinario.AutoRoundedCorners = true;
            this.bttnFiltrarPorVeterinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFiltrarPorVeterinario.DefaultAutoSize = true;
            this.bttnFiltrarPorVeterinario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorVeterinario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorVeterinario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorVeterinario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorVeterinario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorVeterinario.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorVeterinario.Location = new System.Drawing.Point(306, 27);
            this.bttnFiltrarPorVeterinario.Name = "bttnFiltrarPorVeterinario";
            this.bttnFiltrarPorVeterinario.Size = new System.Drawing.Size(65, 27);
            this.bttnFiltrarPorVeterinario.TabIndex = 25;
            this.bttnFiltrarPorVeterinario.Text = "Buscar";
            this.bttnFiltrarPorVeterinario.Click += new System.EventHandler(this.bttnFiltrarPorVeterinario_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fecha";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hora";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mascota";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Veterinario";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ProyectoP3.Properties.Resources.MaterialSymbolsEdit__4_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 135;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::ProyectoP3.Properties.Resources.LetsIconsDelAltFill__1_;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 134;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Atender cita";
            this.dataGridViewImageColumn3.Image = global::ProyectoP3.Properties.Resources.HugeiconsAppointment02;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 135;
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
            // AtenderCita
            // 
            this.AtenderCita.HeaderText = "Atender cita";
            this.AtenderCita.Image = global::ProyectoP3.Properties.Resources.HugeiconsAppointment02;
            this.AtenderCita.Name = "AtenderCita";
            this.AtenderCita.ReadOnly = true;
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.bttnFiltrarPorVeterinario);
            this.Controls.Add(this.bttnFiltrarPorFecha);
            this.Controls.Add(this.txtFiltrarPorFacha);
            this.Controls.Add(this.txtFiltrarPorVeterinario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCita";
            this.Text = "FrmCita";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVCita;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorVeterinario;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorFacha;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorFecha;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorVeterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn elimina;
        private System.Windows.Forms.DataGridViewImageColumn AtenderCita;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
    }
}