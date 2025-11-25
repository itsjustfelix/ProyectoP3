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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
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
            this.groupBoxCitasDia = new System.Windows.Forms.GroupBox();
            this.listBoxCitasDia = new System.Windows.Forms.ListBox();
            this.gunaPolarAreaDataset1 = new Guna.Charts.WinForms.GunaPolarAreaDataset();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.groupBoxCitasDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaChart1
            // 
            chartFont1.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont1;
            this.gunaChart1.Location = new System.Drawing.Point(5, 34);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(670, 296);
            this.gunaChart1.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont4;
            this.gunaChart1.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.gunaChart1.XAxes.Ticks = tick1;
            this.gunaChart1.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.gunaChart1.YAxes.Ticks = tick2;
            this.gunaChart1.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.gunaChart1.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.gunaChart1.ZAxes.Ticks = tick3;
            this.gunaChart1.Load += new System.EventHandler(this.gunaChart1_Load);
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
            this.labelMascotasTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMascotasTitle.Location = new System.Drawing.Point(70, 10);
            this.labelMascotasTitle.Name = "labelMascotasTitle";
            this.labelMascotasTitle.Size = new System.Drawing.Size(100, 23);
            this.labelMascotasTitle.TabIndex = 0;
            this.labelMascotasTitle.Text = "Mascotas registradas";
            // 
            // lblContadorMascotas
            // 
            this.lblContadorMascotas.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorMascotas.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.cardVeterinarios.Paint += new System.Windows.Forms.PaintEventHandler(this.cardVeterinarios_Paint);
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
            this.labelVeterinariosTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeterinariosTitle.Location = new System.Drawing.Point(74, 10);
            this.labelVeterinariosTitle.Name = "labelVeterinariosTitle";
            this.labelVeterinariosTitle.Size = new System.Drawing.Size(116, 23);
            this.labelVeterinariosTitle.TabIndex = 0;
            this.labelVeterinariosTitle.Text = "Veterinarios";
            // 
            // lblContadorVeterinarios
            // 
            this.lblContadorVeterinarios.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorVeterinarios.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cardCitasHoy.Paint += new System.Windows.Forms.PaintEventHandler(this.cardCitasHoy_Paint);
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
            this.labelCitasHoyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitasHoyTitle.Location = new System.Drawing.Point(79, 13);
            this.labelCitasHoyTitle.Name = "labelCitasHoyTitle";
            this.labelCitasHoyTitle.Size = new System.Drawing.Size(100, 23);
            this.labelCitasHoyTitle.TabIndex = 0;
            this.labelCitasHoyTitle.Text = "Citas Hoy";
            // 
            // lblContadorCitasHoy
            // 
            this.lblContadorCitasHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorCitasHoy.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelCitasAtendidasTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitasAtendidasTitle.Location = new System.Drawing.Point(94, 13);
            this.labelCitasAtendidasTitle.Name = "labelCitasAtendidasTitle";
            this.labelCitasAtendidasTitle.Size = new System.Drawing.Size(116, 23);
            this.labelCitasAtendidasTitle.TabIndex = 0;
            this.labelCitasAtendidasTitle.Text = "Citas atendidas";
            this.labelCitasAtendidasTitle.Click += new System.EventHandler(this.labelCitasAtendidasTitle_Click);
            // 
            // lblCitasAtendidas
            // 
            this.lblCitasAtendidas.BackColor = System.Drawing.Color.Transparent;
            this.lblCitasAtendidas.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelChart.Size = new System.Drawing.Size(700, 353);
            this.panelChart.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.Location = new System.Drawing.Point(68, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.Controls.Add(this.groupBoxCitasDia);
            this.panelRight.Controls.Add(this.monthCalendar1);
            this.panelRight.Location = new System.Drawing.Point(724, 327);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1199, 394);
            this.panelRight.TabIndex = 3;
            // 
            // groupBoxCitasDia
            // 
            this.groupBoxCitasDia.Controls.Add(this.listBoxCitasDia);
            this.groupBoxCitasDia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCitasDia.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxCitasDia.Location = new System.Drawing.Point(8, 212);
            this.groupBoxCitasDia.Name = "groupBoxCitasDia";
            this.groupBoxCitasDia.Size = new System.Drawing.Size(356, 150);
            this.groupBoxCitasDia.TabIndex = 0;
            this.groupBoxCitasDia.TabStop = false;
            this.groupBoxCitasDia.Text = "Citas del día";
            // 
            // listBoxCitasDia
            // 
            this.listBoxCitasDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCitasDia.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCitasDia.ItemHeight = 19;
            this.listBoxCitasDia.Location = new System.Drawing.Point(3, 26);
            this.listBoxCitasDia.Name = "listBoxCitasDia";
            this.listBoxCitasDia.Size = new System.Drawing.Size(350, 121);
            this.listBoxCitasDia.TabIndex = 0;
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
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmEstadistica
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelRight);
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
            this.groupBoxCitasDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBoxCitasDia;
        private System.Windows.Forms.ListBox listBoxCitasDia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.Charts.WinForms.GunaPolarAreaDataset gunaPolarAreaDataset1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
