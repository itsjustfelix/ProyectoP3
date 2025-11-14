namespace ProyectoP3
{
    partial class FrmConsulta
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
            this.DGVConsulta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearPDF = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnCrearPDFEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.bttnFiltrarPorFecha = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarPorFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiltrarPorVeterinario = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorVeterinario = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltrarPorMascota = new Guna.UI2.WinForms.Guna2TextBox();
            this.bttnFiltrarPorMascota = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVConsulta
            // 
            this.DGVConsulta.AllowUserToAddRows = false;
            this.DGVConsulta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVConsulta.ColumnHeadersHeight = 15;
            this.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVConsulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVConsulta.Location = new System.Drawing.Point(12, 65);
            this.DGVConsulta.Name = "DGVConsulta";
            this.DGVConsulta.ReadOnly = true;
            this.DGVConsulta.RowHeadersVisible = false;
            this.DGVConsulta.Size = new System.Drawing.Size(1078, 514);
            this.DGVConsulta.TabIndex = 4;
            this.DGVConsulta.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DGVConsulta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DGVConsulta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVConsulta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVConsulta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVConsulta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVConsulta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVConsulta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DGVConsulta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DGVConsulta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVConsulta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVConsulta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVConsulta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVConsulta.ThemeStyle.HeaderStyle.Height = 15;
            this.DGVConsulta.ThemeStyle.ReadOnly = true;
            this.DGVConsulta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DGVConsulta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVConsulta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVConsulta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVConsulta.ThemeStyle.RowsStyle.Height = 22;
            this.DGVConsulta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DGVConsulta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVConsulta_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Codigo";
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
            this.Column10.HeaderText = "Fecha";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Veterinario";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Descripcion";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Diagnostico";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Tratamiento";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // btnCrearPDF
            // 
            this.btnCrearPDF.Animated = true;
            this.btnCrearPDF.AutoRoundedCorners = true;
            this.btnCrearPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnCrearPDF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPDF.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPDF.IndicateFocus = true;
            this.btnCrearPDF.Location = new System.Drawing.Point(582, 585);
            this.btnCrearPDF.Name = "btnCrearPDF";
            this.btnCrearPDF.Size = new System.Drawing.Size(141, 45);
            this.btnCrearPDF.TabIndex = 24;
            this.btnCrearPDF.Text = "Crear PDF";
            this.btnCrearPDF.Click += new System.EventHandler(this.btnCrearPDF_Click_1);
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
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.IndicateFocus = true;
            this.btnEliminar.Location = new System.Drawing.Point(435, 585);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 45);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar Consulta";
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
            this.bttnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.ForeColor = System.Drawing.Color.Black;
            this.bttnActualizar.IndicateFocus = true;
            this.bttnActualizar.Location = new System.Drawing.Point(288, 585);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(141, 45);
            this.bttnActualizar.TabIndex = 22;
            this.bttnActualizar.Text = "Actualizar Consulta";
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Animated = true;
            this.btnGuardar.AutoRoundedCorners = true;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IndicateFocus = true;
            this.btnGuardar.Location = new System.Drawing.Point(141, 585);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 45);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Consulta";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bttnCrearPDFEnviar
            // 
            this.bttnCrearPDFEnviar.Animated = true;
            this.bttnCrearPDFEnviar.AutoRoundedCorners = true;
            this.bttnCrearPDFEnviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnCrearPDFEnviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnCrearPDFEnviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnCrearPDFEnviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnCrearPDFEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.bttnCrearPDFEnviar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCrearPDFEnviar.ForeColor = System.Drawing.Color.Black;
            this.bttnCrearPDFEnviar.IndicateFocus = true;
            this.bttnCrearPDFEnviar.Location = new System.Drawing.Point(729, 585);
            this.bttnCrearPDFEnviar.Name = "bttnCrearPDFEnviar";
            this.bttnCrearPDFEnviar.Size = new System.Drawing.Size(168, 45);
            this.bttnCrearPDFEnviar.TabIndex = 25;
            this.bttnCrearPDFEnviar.Text = "Crear PDF y enviar por email";
            this.bttnCrearPDFEnviar.Click += new System.EventHandler(this.bttnCrearPDFEnviar_Click);
            // 
            // bttnFiltrarPorFecha
            // 
            this.bttnFiltrarPorFecha.Animated = true;
            this.bttnFiltrarPorFecha.AutoRoundedCorners = true;
            this.bttnFiltrarPorFecha.DefaultAutoSize = true;
            this.bttnFiltrarPorFecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorFecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorFecha.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorFecha.Location = new System.Drawing.Point(237, 19);
            this.bttnFiltrarPorFecha.Name = "bttnFiltrarPorFecha";
            this.bttnFiltrarPorFecha.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorFecha.TabIndex = 26;
            this.bttnFiltrarPorFecha.Text = "Filtrar";
            this.bttnFiltrarPorFecha.Click += new System.EventHandler(this.bttnFiltrarPorFecha_Click);
            // 
            // txtFiltrarPorFecha
            // 
            this.txtFiltrarPorFecha.Animated = true;
            this.txtFiltrarPorFecha.AutoRoundedCorners = true;
            this.txtFiltrarPorFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarPorFecha.DefaultText = "";
            this.txtFiltrarPorFecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarPorFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarPorFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorFecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarPorFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorFecha.Location = new System.Drawing.Point(21, 14);
            this.txtFiltrarPorFecha.Name = "txtFiltrarPorFecha";
            this.txtFiltrarPorFecha.PlaceholderText = "Filtrar por fecha";
            this.txtFiltrarPorFecha.SelectedText = "";
            this.txtFiltrarPorFecha.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarPorFecha.TabIndex = 27;
            // 
            // txtFiltrarPorVeterinario
            // 
            this.txtFiltrarPorVeterinario.Animated = true;
            this.txtFiltrarPorVeterinario.AutoRoundedCorners = true;
            this.txtFiltrarPorVeterinario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarPorVeterinario.DefaultText = "";
            this.txtFiltrarPorVeterinario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarPorVeterinario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarPorVeterinario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorVeterinario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorVeterinario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorVeterinario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarPorVeterinario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorVeterinario.Location = new System.Drawing.Point(405, 14);
            this.txtFiltrarPorVeterinario.Name = "txtFiltrarPorVeterinario";
            this.txtFiltrarPorVeterinario.PlaceholderText = "Filtrar por veterinario";
            this.txtFiltrarPorVeterinario.SelectedText = "";
            this.txtFiltrarPorVeterinario.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarPorVeterinario.TabIndex = 29;
            this.txtFiltrarPorVeterinario.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // bttnFiltrarPorVeterinario
            // 
            this.bttnFiltrarPorVeterinario.Animated = true;
            this.bttnFiltrarPorVeterinario.AutoRoundedCorners = true;
            this.bttnFiltrarPorVeterinario.DefaultAutoSize = true;
            this.bttnFiltrarPorVeterinario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorVeterinario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorVeterinario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorVeterinario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorVeterinario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorVeterinario.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorVeterinario.Location = new System.Drawing.Point(621, 19);
            this.bttnFiltrarPorVeterinario.Name = "bttnFiltrarPorVeterinario";
            this.bttnFiltrarPorVeterinario.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorVeterinario.TabIndex = 28;
            this.bttnFiltrarPorVeterinario.Text = "Filtrar";
            this.bttnFiltrarPorVeterinario.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtFiltrarPorMascota
            // 
            this.txtFiltrarPorMascota.Animated = true;
            this.txtFiltrarPorMascota.AutoRoundedCorners = true;
            this.txtFiltrarPorMascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrarPorMascota.DefaultText = "";
            this.txtFiltrarPorMascota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrarPorMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrarPorMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorMascota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrarPorMascota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrarPorMascota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrarPorMascota.Location = new System.Drawing.Point(778, 14);
            this.txtFiltrarPorMascota.Name = "txtFiltrarPorMascota";
            this.txtFiltrarPorMascota.PlaceholderText = "Filtrar por mascota";
            this.txtFiltrarPorMascota.SelectedText = "";
            this.txtFiltrarPorMascota.Size = new System.Drawing.Size(200, 36);
            this.txtFiltrarPorMascota.TabIndex = 31;
            this.txtFiltrarPorMascota.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // bttnFiltrarPorMascota
            // 
            this.bttnFiltrarPorMascota.Animated = true;
            this.bttnFiltrarPorMascota.AutoRoundedCorners = true;
            this.bttnFiltrarPorMascota.DefaultAutoSize = true;
            this.bttnFiltrarPorMascota.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorMascota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttnFiltrarPorMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttnFiltrarPorMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttnFiltrarPorMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bttnFiltrarPorMascota.ForeColor = System.Drawing.Color.White;
            this.bttnFiltrarPorMascota.Location = new System.Drawing.Point(994, 19);
            this.bttnFiltrarPorMascota.Name = "bttnFiltrarPorMascota";
            this.bttnFiltrarPorMascota.Size = new System.Drawing.Size(61, 27);
            this.bttnFiltrarPorMascota.TabIndex = 30;
            this.bttnFiltrarPorMascota.Text = "Filtrar";
            this.bttnFiltrarPorMascota.Click += new System.EventHandler(this.bttnFiltrarPorMascota_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.txtFiltrarPorMascota);
            this.Controls.Add(this.bttnFiltrarPorMascota);
            this.Controls.Add(this.txtFiltrarPorVeterinario);
            this.Controls.Add(this.bttnFiltrarPorVeterinario);
            this.Controls.Add(this.txtFiltrarPorFecha);
            this.Controls.Add(this.bttnFiltrarPorFecha);
            this.Controls.Add(this.bttnCrearPDFEnviar);
            this.Controls.Add(this.btnCrearPDF);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsulta";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private Guna.UI2.WinForms.Guna2Button btnCrearPDF;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button bttnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button bttnCrearPDFEnviar;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorFecha;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorFecha;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorVeterinario;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorVeterinario;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrarPorMascota;
        private Guna.UI2.WinForms.Guna2Button bttnFiltrarPorMascota;
    }
}