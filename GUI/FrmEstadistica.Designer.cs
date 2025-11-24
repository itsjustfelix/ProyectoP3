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
            this.panelTopButtons = new System.Windows.Forms.Panel();
            this.btnTopConsulta = new Guna.UI2.WinForms.Guna2Button();
            this.btnTopCita = new Guna.UI2.WinForms.Guna2Button();
            this.btnTopIA = new Guna.UI2.WinForms.Guna2Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardMascotas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelMascotasTitle = new System.Windows.Forms.Label();
            this.lblContadorMascotas = new System.Windows.Forms.Label();
            this.cardVeterinarios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelVeterinariosTitle = new System.Windows.Forms.Label();
            this.lblContadorVeterinarios = new System.Windows.Forms.Label();
            this.cardCitasHoy = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelCitasHoyTitle = new System.Windows.Forms.Label();
            this.lblContadorCitasHoy = new System.Windows.Forms.Label();
            this.cardCitasAtendidas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelCitasAtendidasTitle = new System.Windows.Forms.Label();
            this.lblCitasAtendidas = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxCitasDia = new System.Windows.Forms.GroupBox();
            this.listBoxCitasDia = new System.Windows.Forms.ListBox();
            this.gunaPolarAreaDataset1 = new Guna.Charts.WinForms.GunaPolarAreaDataset();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelTopButtons.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardMascotas.SuspendLayout();
            this.cardVeterinarios.SuspendLayout();
            this.cardCitasHoy.SuspendLayout();
            this.cardCitasAtendidas.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxCitasDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaChart1
            // 
            chartFont1.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont1;
            this.gunaChart1.Location = new System.Drawing.Point(5, 47);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(670, 260);
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
            // panelTopButtons
            // 
            this.panelTopButtons.Controls.Add(this.pictureBox8);
            this.panelTopButtons.Controls.Add(this.pictureBox7);
            this.panelTopButtons.Controls.Add(this.btnTopConsulta);
            this.panelTopButtons.Controls.Add(this.pictureBox6);
            this.panelTopButtons.Controls.Add(this.btnTopCita);
            this.panelTopButtons.Controls.Add(this.btnTopIA);
            this.panelTopButtons.Location = new System.Drawing.Point(12, 3);
            this.panelTopButtons.Name = "panelTopButtons";
            this.panelTopButtons.Size = new System.Drawing.Size(605, 56);
            this.panelTopButtons.TabIndex = 0;
            // 
            // btnTopConsulta
            // 
            this.btnTopConsulta.AutoRoundedCorners = true;
            this.btnTopConsulta.BorderRadius = 20;
            this.btnTopConsulta.FillColor = System.Drawing.Color.Blue;
            this.btnTopConsulta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopConsulta.ForeColor = System.Drawing.Color.White;
            this.btnTopConsulta.Location = new System.Drawing.Point(8, 3);
            this.btnTopConsulta.Name = "btnTopConsulta";
            this.btnTopConsulta.Size = new System.Drawing.Size(171, 43);
            this.btnTopConsulta.TabIndex = 0;
            this.btnTopConsulta.Text = "Consulta";
            // 
            // btnTopCita
            // 
            this.btnTopCita.AutoRoundedCorners = true;
            this.btnTopCita.BorderRadius = 20;
            this.btnTopCita.FillColor = System.Drawing.Color.Blue;
            this.btnTopCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopCita.ForeColor = System.Drawing.Color.White;
            this.btnTopCita.Location = new System.Drawing.Point(197, 3);
            this.btnTopCita.Name = "btnTopCita";
            this.btnTopCita.Size = new System.Drawing.Size(149, 43);
            this.btnTopCita.TabIndex = 1;
            this.btnTopCita.Text = "Cita";
            // 
            // btnTopIA
            // 
            this.btnTopIA.AutoRoundedCorners = true;
            this.btnTopIA.BorderRadius = 21;
            this.btnTopIA.FillColor = System.Drawing.Color.Blue;
            this.btnTopIA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopIA.ForeColor = System.Drawing.Color.White;
            this.btnTopIA.Location = new System.Drawing.Point(391, 2);
            this.btnTopIA.Name = "btnTopIA";
            this.btnTopIA.Size = new System.Drawing.Size(148, 44);
            this.btnTopIA.TabIndex = 2;
            this.btnTopIA.Text = "IA";
            this.btnTopIA.Click += new System.EventHandler(this.btnTopIA_Click);
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.cardMascotas);
            this.panelCards.Controls.Add(this.cardVeterinarios);
            this.panelCards.Controls.Add(this.cardCitasHoy);
            this.panelCards.Controls.Add(this.cardCitasAtendidas);
            this.panelCards.Location = new System.Drawing.Point(12, 65);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(650, 268);
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
            this.lblContadorMascotas.Location = new System.Drawing.Point(79, 45);
            this.lblContadorMascotas.Name = "lblContadorMascotas";
            this.lblContadorMascotas.Size = new System.Drawing.Size(100, 59);
            this.lblContadorMascotas.TabIndex = 1;
            this.lblContadorMascotas.Text = "0";
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
            // labelVeterinariosTitle
            // 
            this.labelVeterinariosTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelVeterinariosTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeterinariosTitle.Location = new System.Drawing.Point(74, 10);
            this.labelVeterinariosTitle.Name = "labelVeterinariosTitle";
            this.labelVeterinariosTitle.Size = new System.Drawing.Size(100, 23);
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
            this.cardCitasHoy.Location = new System.Drawing.Point(41, 130);
            this.cardCitasHoy.Name = "cardCitasHoy";
            this.cardCitasHoy.Size = new System.Drawing.Size(250, 120);
            this.cardCitasHoy.TabIndex = 2;
            this.cardCitasHoy.Paint += new System.Windows.Forms.PaintEventHandler(this.cardCitasHoy_Paint);
            // 
            // labelCitasHoyTitle
            // 
            this.labelCitasHoyTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCitasHoyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitasHoyTitle.Location = new System.Drawing.Point(70, 13);
            this.labelCitasHoyTitle.Name = "labelCitasHoyTitle";
            this.labelCitasHoyTitle.Size = new System.Drawing.Size(100, 23);
            this.labelCitasHoyTitle.TabIndex = 0;
            this.labelCitasHoyTitle.Text = "Citas hoy";
            // 
            // lblContadorCitasHoy
            // 
            this.lblContadorCitasHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorCitasHoy.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorCitasHoy.Location = new System.Drawing.Point(88, 46);
            this.lblContadorCitasHoy.Name = "lblContadorCitasHoy";
            this.lblContadorCitasHoy.Size = new System.Drawing.Size(100, 59);
            this.lblContadorCitasHoy.TabIndex = 1;
            this.lblContadorCitasHoy.Text = "0";
            // 
            // cardCitasAtendidas
            // 
            this.cardCitasAtendidas.BackColor = System.Drawing.Color.Gainsboro;
            this.cardCitasAtendidas.BorderRadius = 12;
            this.cardCitasAtendidas.Controls.Add(this.pictureBox4);
            this.cardCitasAtendidas.Controls.Add(this.labelCitasAtendidasTitle);
            this.cardCitasAtendidas.Controls.Add(this.lblCitasAtendidas);
            this.cardCitasAtendidas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.cardCitasAtendidas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.cardCitasAtendidas.Location = new System.Drawing.Point(387, 130);
            this.cardCitasAtendidas.Name = "cardCitasAtendidas";
            this.cardCitasAtendidas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cardCitasAtendidas.ShadowDecoration.BorderRadius = 20;
            this.cardCitasAtendidas.Size = new System.Drawing.Size(250, 120);
            this.cardCitasAtendidas.TabIndex = 3;
            // 
            // labelCitasAtendidasTitle
            // 
            this.labelCitasAtendidasTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCitasAtendidasTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCitasAtendidasTitle.Location = new System.Drawing.Point(74, 10);
            this.labelCitasAtendidasTitle.Name = "labelCitasAtendidasTitle";
            this.labelCitasAtendidasTitle.Size = new System.Drawing.Size(116, 23);
            this.labelCitasAtendidasTitle.TabIndex = 0;
            this.labelCitasAtendidasTitle.Text = "Citas atendidas";
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
            this.panelChart.Location = new System.Drawing.Point(15, 341);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(700, 316);
            this.panelChart.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.WindowText;
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
            this.panelRight.Location = new System.Drawing.Point(721, 294);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1199, 363);
            this.panelRight.TabIndex = 3;
            // 
            // groupBoxCitasDia
            // 
            this.groupBoxCitasDia.Controls.Add(this.listBoxCitasDia);
            this.groupBoxCitasDia.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBoxCitasDia.Location = new System.Drawing.Point(0, 189);
            this.groupBoxCitasDia.Name = "groupBoxCitasDia";
            this.groupBoxCitasDia.Size = new System.Drawing.Size(356, 150);
            this.groupBoxCitasDia.TabIndex = 0;
            this.groupBoxCitasDia.TabStop = false;
            this.groupBoxCitasDia.Text = "Citas del día";
            // 
            // listBoxCitasDia
            // 
            this.listBoxCitasDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCitasDia.ItemHeight = 21;
            this.listBoxCitasDia.Location = new System.Drawing.Point(3, 24);
            this.listBoxCitasDia.Name = "listBoxCitasDia";
            this.listBoxCitasDia.Size = new System.Drawing.Size(350, 123);
            this.listBoxCitasDia.TabIndex = 0;
            // 
            // gunaPolarAreaDataset1
            // 
            this.gunaPolarAreaDataset1.Label = "PolarArea1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64__1_;
            this.pictureBox3.Location = new System.Drawing.Point(15, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64__3_;
            this.pictureBox4.Location = new System.Drawing.Point(27, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProyectoP3.Properties.Resources.my_vet_Photoroom;
            this.pictureBox2.Location = new System.Drawing.Point(724, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::ProyectoP3.Properties.Resources.icons8_veterinary_64__4_;
            this.pictureBox8.Location = new System.Drawing.Point(20, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(412, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 33);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(209, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 33);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // FrmEstadistica
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelTopButtons);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistica";
            this.Text = "re";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load_1);
            this.panelTopButtons.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.cardMascotas.ResumeLayout(false);
            this.cardVeterinarios.ResumeLayout(false);
            this.cardCitasHoy.ResumeLayout(false);
            this.cardCitasAtendidas.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.groupBoxCitasDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Campos
        private Guna.Charts.WinForms.GunaChart gunaChart1;

        private System.Windows.Forms.Panel panelTopButtons;
        private Guna.UI2.WinForms.Guna2Button btnTopConsulta;
        private Guna.UI2.WinForms.Guna2Button btnTopCita;
        private Guna.UI2.WinForms.Guna2Button btnTopIA;

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
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
