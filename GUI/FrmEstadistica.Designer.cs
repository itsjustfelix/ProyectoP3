namespace ProyectoP3
{
    partial class FrmEstadistica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.Charts.WinForms.ChartFont chartFont33 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont34 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont35 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont36 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid13 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick13 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont37 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid14 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick14 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont38 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid15 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel5 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont39 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick15 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont40 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardMascotas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelMascotasTitle = new System.Windows.Forms.Label();
            this.lblContadorMascotas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardVeterinarios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelVeterinariosTitle = new System.Windows.Forms.Label();
            this.lblContadorVeterinarios = new System.Windows.Forms.Label();
            this.cardCitasHoy = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelCitasHoyTitle = new System.Windows.Forms.Label();
            this.lblContadorCitasHoy = new System.Windows.Forms.Label();
            this.cardCitasAtendidas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelCitasAtendidasTitle = new System.Windows.Forms.Label();
            this.lblCitasAtendidas = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvCitasHoy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtenderCita = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaPolarAreaDataset1 = new Guna.Charts.WinForms.GunaPolarAreaDataset();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCards.SuspendLayout();
            this.cardMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cardVeterinarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.cardCitasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cardCitasAtendidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelChart.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasHoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaChart1
            // 
            chartFont33.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont33;
            this.gunaChart1.Location = new System.Drawing.Point(5, 34);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(572, 296);
            this.gunaChart1.TabIndex = 0;
            chartFont34.FontName = "Arial";
            chartFont34.Size = 12;
            chartFont34.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont34;
            chartFont35.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont35;
            chartFont36.FontName = "Arial";
            chartFont36.Size = 9;
            chartFont36.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont36;
            this.gunaChart1.XAxes.GridLines = grid13;
            chartFont37.FontName = "Arial";
            tick13.Font = chartFont37;
            this.gunaChart1.XAxes.Ticks = tick13;
            this.gunaChart1.YAxes.GridLines = grid14;
            chartFont38.FontName = "Arial";
            tick14.Font = chartFont38;
            this.gunaChart1.YAxes.Ticks = tick14;
            this.gunaChart1.ZAxes.GridLines = grid15;
            chartFont39.FontName = "Arial";
            pointLabel5.Font = chartFont39;
            this.gunaChart1.ZAxes.PointLabels = pointLabel5;
            chartFont40.FontName = "Arial";
            tick15.Font = chartFont40;
            this.gunaChart1.ZAxes.Ticks = tick15;
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.cardMascotas);
            this.panelCards.Controls.Add(this.cardVeterinarios);
            this.panelCards.Controls.Add(this.cardCitasHoy);
            this.panelCards.Controls.Add(this.cardCitasAtendidas);
            this.panelCards.Location = new System.Drawing.Point(12, 15);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(703, 293);
            this.panelCards.TabIndex = 1;
            // 
            // cardMascotas
            // 
            this.cardMascotas.BorderRadius = 12;
            this.cardMascotas.Controls.Add(this.labelMascotasTitle);
            this.cardMascotas.Controls.Add(this.lblContadorMascotas);
            this.cardMascotas.Controls.Add(this.pictureBox1);
            this.cardMascotas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cardMascotas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cardMascotas.Location = new System.Drawing.Point(41, 5);
            this.cardMascotas.Name = "cardMascotas";
            this.cardMascotas.Size = new System.Drawing.Size(250, 120);
            this.cardMascotas.TabIndex = 0;
            // 
            // labelMascotasTitle
            // 
            this.labelMascotasTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMascotasTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelMascotasTitle.Location = new System.Drawing.Point(70, 10);
            this.labelMascotasTitle.Name = "labelMascotasTitle";
            this.labelMascotasTitle.Size = new System.Drawing.Size(100, 23);
            this.labelMascotasTitle.TabIndex = 0;
            this.labelMascotasTitle.Text = "Mascotas registradas";
            // 
            // lblContadorMascotas
            // 
            this.lblContadorMascotas.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorMascotas.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorMascotas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContadorMascotas.Location = new System.Drawing.Point(88, 50);
            this.lblContadorMascotas.Name = "lblContadorMascotas";
            this.lblContadorMascotas.Size = new System.Drawing.Size(100, 59);
            this.lblContadorMascotas.TabIndex = 1;
            this.lblContadorMascotas.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cardVeterinarios
            // 
            this.cardVeterinarios.BorderRadius = 12;
            this.cardVeterinarios.Controls.Add(this.pictureBox5);
            this.cardVeterinarios.Controls.Add(this.labelVeterinariosTitle);
            this.cardVeterinarios.Controls.Add(this.lblContadorVeterinarios);
            this.cardVeterinarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cardVeterinarios.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cardVeterinarios.Location = new System.Drawing.Point(387, 5);
            this.cardVeterinarios.Name = "cardVeterinarios";
            this.cardVeterinarios.Size = new System.Drawing.Size(250, 120);
            this.cardVeterinarios.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64__2_;
            this.pictureBox5.Location = new System.Drawing.Point(25, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // labelVeterinariosTitle
            // 
            this.labelVeterinariosTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelVeterinariosTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelVeterinariosTitle.Location = new System.Drawing.Point(74, 10);
            this.labelVeterinariosTitle.Name = "labelVeterinariosTitle";
            this.labelVeterinariosTitle.Size = new System.Drawing.Size(116, 23);
            this.labelVeterinariosTitle.TabIndex = 0;
            this.labelVeterinariosTitle.Text = "Veterinarios";
            // 
            // lblContadorVeterinarios
            // 
            this.lblContadorVeterinarios.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorVeterinarios.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblContadorVeterinarios.Location = new System.Drawing.Point(110, 50);
            this.lblContadorVeterinarios.Name = "lblContadorVeterinarios";
            this.lblContadorVeterinarios.Size = new System.Drawing.Size(100, 70);
            this.lblContadorVeterinarios.TabIndex = 1;
            this.lblContadorVeterinarios.Text = "0";
            // 
            // cardCitasHoy
            // 
            this.cardCitasHoy.BorderRadius = 12;
            this.cardCitasHoy.Controls.Add(this.pictureBox3);
            this.cardCitasHoy.Controls.Add(this.labelCitasHoyTitle);
            this.cardCitasHoy.Controls.Add(this.lblContadorCitasHoy);
            this.cardCitasHoy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.cardCitasHoy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.cardCitasHoy.Location = new System.Drawing.Point(41, 150);
            this.cardCitasHoy.Name = "cardCitasHoy";
            this.cardCitasHoy.Size = new System.Drawing.Size(250, 120);
            this.cardCitasHoy.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64__1_;
            this.pictureBox3.Location = new System.Drawing.Point(23, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // labelCitasHoyTitle
            // 
            this.labelCitasHoyTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCitasHoyTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelCitasHoyTitle.Location = new System.Drawing.Point(79, 13);
            this.labelCitasHoyTitle.Name = "labelCitasHoyTitle";
            this.labelCitasHoyTitle.Size = new System.Drawing.Size(100, 23);
            this.labelCitasHoyTitle.TabIndex = 0;
            this.labelCitasHoyTitle.Text = "Citas Hoy";
            // 
            // lblContadorCitasHoy
            // 
            this.lblContadorCitasHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorCitasHoy.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblContadorCitasHoy.Location = new System.Drawing.Point(88, 49);
            this.lblContadorCitasHoy.Name = "lblContadorCitasHoy";
            this.lblContadorCitasHoy.Size = new System.Drawing.Size(100, 59);
            this.lblContadorCitasHoy.TabIndex = 1;
            this.lblContadorCitasHoy.Text = "0";
            // 
            // cardCitasAtendidas
            // 
            this.cardCitasAtendidas.BackColor = System.Drawing.Color.Transparent;
            this.cardCitasAtendidas.BorderRadius = 12;
            this.cardCitasAtendidas.Controls.Add(this.pictureBox4);
            this.cardCitasAtendidas.Controls.Add(this.labelCitasAtendidasTitle);
            this.cardCitasAtendidas.Controls.Add(this.lblCitasAtendidas);
            this.cardCitasAtendidas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.cardCitasAtendidas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.cardCitasAtendidas.Location = new System.Drawing.Point(387, 150);
            this.cardCitasAtendidas.Name = "cardCitasAtendidas";
            this.cardCitasAtendidas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cardCitasAtendidas.ShadowDecoration.BorderRadius = 20;
            this.cardCitasAtendidas.Size = new System.Drawing.Size(250, 120);
            this.cardCitasAtendidas.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64__3_;
            this.pictureBox4.Location = new System.Drawing.Point(27, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // labelCitasAtendidasTitle
            // 
            this.labelCitasAtendidasTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCitasAtendidasTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelCitasAtendidasTitle.Location = new System.Drawing.Point(74, 13);
            this.labelCitasAtendidasTitle.Name = "labelCitasAtendidasTitle";
            this.labelCitasAtendidasTitle.Size = new System.Drawing.Size(116, 23);
            this.labelCitasAtendidasTitle.TabIndex = 0;
            this.labelCitasAtendidasTitle.Text = "Citas atendidas";
            this.labelCitasAtendidasTitle.Click += new System.EventHandler(this.labelCitasAtendidasTitle_Click);
            // 
            // lblCitasAtendidas
            // 
            this.lblCitasAtendidas.BackColor = System.Drawing.Color.Transparent;
            this.lblCitasAtendidas.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblCitasAtendidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblCitasAtendidas.Location = new System.Drawing.Point(110, 50);
            this.lblCitasAtendidas.Name = "lblCitasAtendidas";
            this.lblCitasAtendidas.Size = new System.Drawing.Size(100, 58);
            this.lblCitasAtendidas.TabIndex = 1;
            this.lblCitasAtendidas.Text = "0";
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.gunaChart1);
            this.panelChart.Location = new System.Drawing.Point(12, 336);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(597, 402);
            this.panelChart.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(132, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.Controls.Add(this.dgvCitasHoy);
            this.panelRight.Controls.Add(this.monthCalendar1);
            this.panelRight.Location = new System.Drawing.Point(615, 336);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(473, 402);
            this.panelRight.TabIndex = 3;
            // 
            // dgvCitasHoy
            // 
            this.dgvCitasHoy.AllowUserToAddRows = false;
            this.dgvCitasHoy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvCitasHoy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCitasHoy.ColumnHeadersHeight = 15;
            this.dgvCitasHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCitasHoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.AtenderCita});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitasHoy.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCitasHoy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvCitasHoy.Location = new System.Drawing.Point(14, 189);
            this.dgvCitasHoy.Name = "dgvCitasHoy";
            this.dgvCitasHoy.ReadOnly = true;
            this.dgvCitasHoy.RowHeadersVisible = false;
            this.dgvCitasHoy.Size = new System.Drawing.Size(453, 210);
            this.dgvCitasHoy.TabIndex = 0;
            this.dgvCitasHoy.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvCitasHoy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvCitasHoy.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCitasHoy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCitasHoy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCitasHoy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCitasHoy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCitasHoy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvCitasHoy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvCitasHoy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCitasHoy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCitasHoy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCitasHoy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCitasHoy.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvCitasHoy.ThemeStyle.ReadOnly = true;
            this.dgvCitasHoy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvCitasHoy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCitasHoy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCitasHoy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCitasHoy.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCitasHoy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvCitasHoy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCitasHoy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitasHoy_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mascota";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Veterinario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // AtenderCita
            // 
            this.AtenderCita.HeaderText = "Atender Cita";
            this.AtenderCita.Image = global::ProyectoP3.Properties.Resources.HugeiconsAppointment02;
            this.AtenderCita.Name = "AtenderCita";
            this.AtenderCita.ReadOnly = true;
            // 
            // gunaPolarAreaDataset1
            // 
            this.gunaPolarAreaDataset1.Label = "PolarArea1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProyectoP3.Properties.Resources.my_vet_Photoroom;
            this.pictureBox2.Location = new System.Drawing.Point(724, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(626, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Citas Del Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(15, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total De Citas Por Fecha";
            // 
            // FrmEstadistica
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistica";
            this.Text = "re";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load_1);
            this.panelCards.ResumeLayout(false);
            this.cardMascotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cardVeterinarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.cardCitasHoy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cardCitasAtendidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelChart.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasHoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Campos
        private Guna.Charts.WinForms.GunaChart gunaChart1;

        private System.Windows.Forms.Panel panelCards;
        private Guna.UI2.WinForms.Guna2GradientPanel cardMascotas;
        private Guna.UI2.WinForms.Guna2GradientPanel cardVeterinarios;
        private Guna.UI2.WinForms.Guna2GradientPanel cardCitasHoy;
        private Guna.UI2.WinForms.Guna2GradientPanel cardCitasAtendidas;

        private System.Windows.Forms.Label labelMascotasTitle;
        private System.Windows.Forms.Label lblContadorMascotas;
        private System.Windows.Forms.Label labelVeterinariosTitle;
        private System.Windows.Forms.Label lblContadorVeterinarios;
        private System.Windows.Forms.Label labelCitasHoyTitle;
        private System.Windows.Forms.Label lblContadorCitasHoy;
        private System.Windows.Forms.Label labelCitasAtendidasTitle;
        private System.Windows.Forms.Label lblCitasAtendidas;

        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.Charts.WinForms.GunaPolarAreaDataset gunaPolarAreaDataset1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCitasHoy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn AtenderCita;
    }
}
