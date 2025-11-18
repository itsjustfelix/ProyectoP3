using System;

namespace ProyectoP3
{
    partial class FrmPropietario
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
            this.DGVPropietario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.elimina = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnFiltrarPorCedula = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarPropietario = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPropietario
            // 
            this.DGVPropietario.AllowUserToAddRows = false;
            this.DGVPropietario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVPropietario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPropietario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPropietario.ColumnHeadersHeight = 15;
            this.DGVPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVPropietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Editar,
            this.elimina});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPropietario.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPropietario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVPropietario.Location = new System.Drawing.Point(12, 57);
            this.DGVPropietario.Name = "DGVPropietario";
            this.DGVPropietario.ReadOnly = true;
            this.DGVPropietario.RowHeadersVisible = false;
            this.DGVPropietario.Size = new System.Drawing.Size(1074, 492);
            this.DGVPropietario.TabIndex = 4;
            this.DGVPropietario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVPropietario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVPropietario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVPropietario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVPropietario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVPropietario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVPropietario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVPropietario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVPropietario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVPropietario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVPropietario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPropietario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVPropietario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVPropietario.ThemeStyle.HeaderStyle.Height = 15;
            this.DGVPropietario.ThemeStyle.ReadOnly = true;
            this.DGVPropietario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVPropietario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPropietario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVPropietario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVPropietario.ThemeStyle.RowsStyle.Height = 22;
            this.DGVPropietario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVPropietario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVPropietario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPropietario_CellContentClick);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Nombre";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Apellido Paterno";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Apellido Materno";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Sexo";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Numero Telefonico";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Email";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
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
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(505, 578);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Propietario";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bttnFiltrarPorCedula
            // 
            this.bttnFiltrarPorCedula.Animated = true;
            this.bttnFiltrarPorCedula.AutoRoundedCorners = true;
            this.bttnFiltrarPorCedula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFiltrarPorCedula.DefaultAutoSize = true;
            this.bttnFiltrarPorCedula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorCedula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorCedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorCedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorCedula.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorCedula.Location = new System.Drawing.Point(218, 17);
            this.bttnFiltrarPorCedula.Name = "bttnFiltrarPorCedula";
            this.bttnFiltrarPorCedula.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorCedula.TabIndex = 8;
            this.bttnFiltrarPorCedula.Text = "Filtrar";
            this.bttnFiltrarPorCedula.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.txtFiltrarPropietario.Location = new System.Drawing.Point(12, 12);
            this.txtFiltrarPropietario.Name = "txtFiltrarPropietario";
            this.txtFiltrarPropietario.PlaceholderText = "Filtrar por Cedula";
            this.txtFiltrarPropietario.SelectedText = "";
            this.txtFiltrarPropietario.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarPropietario.TabIndex = 9;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::ProyectoP3.Properties.Resources.MaterialSymbolsEdit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 120;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::ProyectoP3.Properties.Resources.LetsIconsDelAltFill;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 119;
            // 
            // FrmPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarPropietario);
            this.Controls.Add(this.bttnFiltrarPorCedula);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVPropietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPropietario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVPropietario;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorCedula;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPropietario;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn elimina;
    }
}