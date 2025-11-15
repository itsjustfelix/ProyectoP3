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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnAtenderCita = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarPorVeterinario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltrarPorFacha = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorFecha = new Guna.UI2.WinForms.Guna2Button();
            this.bttnFiltrarPorVeterinario = new Guna.UI2.WinForms.Guna2Button();
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
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            this.btnEliminar.Location = new System.Drawing.Point(514, 610);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 45);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar Cita";
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
            this.bttnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.ForeColor = System.Drawing.Color.Black;
            this.bttnActualizar.IndicateFocus = true;
            this.bttnActualizar.Location = new System.Drawing.Point(367, 610);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(141, 45);
            this.bttnActualizar.TabIndex = 18;
            this.bttnActualizar.Text = "Actualizar Cita";
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
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(220, 610);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Cita";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bttnAtenderCita
            // 
            this.bttnAtenderCita.Animated = true;
            this.bttnAtenderCita.AutoRoundedCorners = true;
            this.bttnAtenderCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAtenderCita.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnAtenderCita.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnAtenderCita.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnAtenderCita.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnAtenderCita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.bttnAtenderCita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAtenderCita.ForeColor = System.Drawing.Color.Black;
            this.bttnAtenderCita.IndicateFocus = true;
            this.bttnAtenderCita.Location = new System.Drawing.Point(661, 610);
            this.bttnAtenderCita.Name = "bttnAtenderCita";
            this.bttnAtenderCita.Size = new System.Drawing.Size(141, 45);
            this.bttnAtenderCita.TabIndex = 20;
            this.bttnAtenderCita.Text = "Atender Cita";
            this.bttnAtenderCita.Click += new System.EventHandler(this.bttnAtenderCita_Click);
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
            this.Controls.Add(this.bttnAtenderCita);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bttnActualizar);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button bttnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button bttnAtenderCita;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorVeterinario;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorFacha;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorFecha;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorVeterinario;
    }
}