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
            this.lblMascotas = new System.Windows.Forms.Label();
            this.cardVeterinarios = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelVeterinariosTitle = new System.Windows.Forms.Label();
            this.lblVeterinarios = new System.Windows.Forms.Label();
            this.cardCitasHoy = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelCitasHoyTitle = new System.Windows.Forms.Label();
            this.lblCitasHoy = new System.Windows.Forms.Label();
            this.cardCitasAtendidas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelCitasAtendidasTitle = new System.Windows.Forms.Label();
            this.lblCitasAtendidas = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxCitasDia = new System.Windows.Forms.GroupBox();
            this.listBoxCitasDia = new System.Windows.Forms.ListBox();
            this.panelTopButtons.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardMascotas.SuspendLayout();
            this.cardVeterinarios.SuspendLayout();
            this.cardCitasHoy.SuspendLayout();
            this.cardCitasAtendidas.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxCitasDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaChart1
            // 
            chartFont1.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont1;
            this.gunaChart1.Location = new System.Drawing.Point(10, 10);
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
            // 
            // panelTopButtons
            // 
            this.panelTopButtons.Controls.Add(this.btnTopConsulta);
            this.panelTopButtons.Controls.Add(this.btnTopCita);
            this.panelTopButtons.Controls.Add(this.btnTopIA);
            this.panelTopButtons.Location = new System.Drawing.Point(15, 15);
            this.panelTopButtons.Name = "panelTopButtons";
            this.panelTopButtons.Size = new System.Drawing.Size(700, 56);
            this.panelTopButtons.TabIndex = 0;
            // 
            // btnTopConsulta
            // 
            this.btnTopConsulta.AutoRoundedCorners = true;
            this.btnTopConsulta.BorderRadius = 16;
            this.btnTopConsulta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnTopConsulta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopConsulta.ForeColor = System.Drawing.Color.White;
            this.btnTopConsulta.Location = new System.Drawing.Point(10, 10);
            this.btnTopConsulta.Name = "btnTopConsulta";
            this.btnTopConsulta.Size = new System.Drawing.Size(140, 35);
            this.btnTopConsulta.TabIndex = 0;
            this.btnTopConsulta.Text = "Consulta";
            // 
            // btnTopCita
            // 
            this.btnTopCita.AutoRoundedCorners = true;
            this.btnTopCita.BorderRadius = 16;
            this.btnTopCita.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnTopCita.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopCita.ForeColor = System.Drawing.Color.White;
            this.btnTopCita.Location = new System.Drawing.Point(160, 10);
            this.btnTopCita.Name = "btnTopCita";
            this.btnTopCita.Size = new System.Drawing.Size(140, 35);
            this.btnTopCita.TabIndex = 1;
            this.btnTopCita.Text = "Cita";
            // 
            // btnTopIA
            // 
            this.btnTopIA.AutoRoundedCorners = true;
            this.btnTopIA.BorderRadius = 16;
            this.btnTopIA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnTopIA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopIA.ForeColor = System.Drawing.Color.White;
            this.btnTopIA.Location = new System.Drawing.Point(310, 10);
            this.btnTopIA.Name = "btnTopIA";
            this.btnTopIA.Size = new System.Drawing.Size(140, 35);
            this.btnTopIA.TabIndex = 2;
            this.btnTopIA.Text = "IA";
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.cardMascotas);
            this.panelCards.Controls.Add(this.cardVeterinarios);
            this.panelCards.Controls.Add(this.cardCitasHoy);
            this.panelCards.Controls.Add(this.cardCitasAtendidas);
            this.panelCards.Location = new System.Drawing.Point(15, 85);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(700, 120);
            this.panelCards.TabIndex = 1;
            // 
            // cardMascotas
            // 
            this.cardMascotas.BorderRadius = 12;
            this.cardMascotas.Controls.Add(this.labelMascotasTitle);
            this.cardMascotas.Controls.Add(this.lblMascotas);
            this.cardMascotas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cardMascotas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cardMascotas.Location = new System.Drawing.Point(5, 5);
            this.cardMascotas.Name = "cardMascotas";
            this.cardMascotas.Size = new System.Drawing.Size(160, 90);
            this.cardMascotas.TabIndex = 0;
            // 
            // labelMascotasTitle
            // 
            this.labelMascotasTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelMascotasTitle.Location = new System.Drawing.Point(10, 10);
            this.labelMascotasTitle.Name = "labelMascotasTitle";
            this.labelMascotasTitle.Size = new System.Drawing.Size(100, 23);
            this.labelMascotasTitle.TabIndex = 0;
            this.labelMascotasTitle.Text = "Mascotas registradas";
            // 
            // lblMascotas
            // 
            this.lblMascotas.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblMascotas.Location = new System.Drawing.Point(110, 50);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(100, 23);
            this.lblMascotas.TabIndex = 1;
            this.lblMascotas.Text = "0";
            // 
            // cardVeterinarios
            // 
            this.cardVeterinarios.BorderRadius = 12;
            this.cardVeterinarios.Controls.Add(this.labelVeterinariosTitle);
            this.cardVeterinarios.Controls.Add(this.lblVeterinarios);
            this.cardVeterinarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cardVeterinarios.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cardVeterinarios.Location = new System.Drawing.Point(180, 5);
            this.cardVeterinarios.Name = "cardVeterinarios";
            this.cardVeterinarios.Size = new System.Drawing.Size(160, 90);
            this.cardVeterinarios.TabIndex = 1;
            // 
            // labelVeterinariosTitle
            // 
            this.labelVeterinariosTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelVeterinariosTitle.Location = new System.Drawing.Point(10, 10);
            this.labelVeterinariosTitle.Name = "labelVeterinariosTitle";
            this.labelVeterinariosTitle.Size = new System.Drawing.Size(100, 23);
            this.labelVeterinariosTitle.TabIndex = 0;
            this.labelVeterinariosTitle.Text = "Veterinarios";
            // 
            // lblVeterinarios
            // 
            this.lblVeterinarios.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblVeterinarios.Location = new System.Drawing.Point(110, 50);
            this.lblVeterinarios.Name = "lblVeterinarios";
            this.lblVeterinarios.Size = new System.Drawing.Size(100, 23);
            this.lblVeterinarios.TabIndex = 1;
            this.lblVeterinarios.Text = "0";
            // 
            // cardCitasHoy
            // 
            this.cardCitasHoy.BorderRadius = 12;
            this.cardCitasHoy.Controls.Add(this.labelCitasHoyTitle);
            this.cardCitasHoy.Controls.Add(this.lblCitasHoy);
            this.cardCitasHoy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.cardCitasHoy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.cardCitasHoy.Location = new System.Drawing.Point(355, 5);
            this.cardCitasHoy.Name = "cardCitasHoy";
            this.cardCitasHoy.Size = new System.Drawing.Size(160, 90);
            this.cardCitasHoy.TabIndex = 2;
            // 
            // labelCitasHoyTitle
            // 
            this.labelCitasHoyTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelCitasHoyTitle.Location = new System.Drawing.Point(10, 10);
            this.labelCitasHoyTitle.Name = "labelCitasHoyTitle";
            this.labelCitasHoyTitle.Size = new System.Drawing.Size(100, 23);
            this.labelCitasHoyTitle.TabIndex = 0;
            this.labelCitasHoyTitle.Text = "Citas hoy";
            // 
            // lblCitasHoy
            // 
            this.lblCitasHoy.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCitasHoy.Location = new System.Drawing.Point(110, 50);
            this.lblCitasHoy.Name = "lblCitasHoy";
            this.lblCitasHoy.Size = new System.Drawing.Size(100, 23);
            this.lblCitasHoy.TabIndex = 1;
            this.lblCitasHoy.Text = "0";
            // 
            // cardCitasAtendidas
            // 
            this.cardCitasAtendidas.BorderRadius = 12;
            this.cardCitasAtendidas.Controls.Add(this.labelCitasAtendidasTitle);
            this.cardCitasAtendidas.Controls.Add(this.lblCitasAtendidas);
            this.cardCitasAtendidas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.cardCitasAtendidas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.cardCitasAtendidas.Location = new System.Drawing.Point(530, 5);
            this.cardCitasAtendidas.Name = "cardCitasAtendidas";
            this.cardCitasAtendidas.Size = new System.Drawing.Size(160, 90);
            this.cardCitasAtendidas.TabIndex = 3;
            // 
            // labelCitasAtendidasTitle
            // 
            this.labelCitasAtendidasTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelCitasAtendidasTitle.Location = new System.Drawing.Point(10, 10);
            this.labelCitasAtendidasTitle.Name = "labelCitasAtendidasTitle";
            this.labelCitasAtendidasTitle.Size = new System.Drawing.Size(100, 23);
            this.labelCitasAtendidasTitle.TabIndex = 0;
            this.labelCitasAtendidasTitle.Text = "Citas atendidas";
            // 
            // lblCitasAtendidas
            // 
            this.lblCitasAtendidas.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCitasAtendidas.Location = new System.Drawing.Point(110, 50);
            this.lblCitasAtendidas.Name = "lblCitasAtendidas";
            this.lblCitasAtendidas.Size = new System.Drawing.Size(100, 23);
            this.lblCitasAtendidas.TabIndex = 1;
            this.lblCitasAtendidas.Text = "0";
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.gunaChart1);
            this.panelChart.Location = new System.Drawing.Point(15, 220);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(700, 500);
            this.panelChart.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(31, 172);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxCitasDia);
            this.panelRight.Controls.Add(this.monthCalendar1);
            this.panelRight.Location = new System.Drawing.Point(730, 85);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(350, 635);
            this.panelRight.TabIndex = 3;
            // 
            // groupBoxCitasDia
            // 
            this.groupBoxCitasDia.Controls.Add(this.listBoxCitasDia);
            this.groupBoxCitasDia.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBoxCitasDia.Location = new System.Drawing.Point(10, 10);
            this.groupBoxCitasDia.Name = "groupBoxCitasDia";
            this.groupBoxCitasDia.Size = new System.Drawing.Size(330, 150);
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
            this.listBoxCitasDia.Size = new System.Drawing.Size(324, 123);
            this.listBoxCitasDia.TabIndex = 0;
            // 
            // FrmEstadistica
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.panelTopButtons);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistica";
            this.panelTopButtons.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.cardMascotas.ResumeLayout(false);
            this.cardVeterinarios.ResumeLayout(false);
            this.cardCitasHoy.ResumeLayout(false);
            this.cardCitasAtendidas.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.groupBoxCitasDia.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.Label labelVeterinariosTitle;
        private System.Windows.Forms.Label lblVeterinarios;
        private System.Windows.Forms.Label labelCitasHoyTitle;
        private System.Windows.Forms.Label lblCitasHoy;
        private System.Windows.Forms.Label labelCitasAtendidasTitle;
        private System.Windows.Forms.Label lblCitasAtendidas;

        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxCitasDia;
        private System.Windows.Forms.ListBox listBoxCitasDia;
    }
}
