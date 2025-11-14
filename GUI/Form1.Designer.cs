namespace ProyectoP3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsulta = new Guna.UI2.WinForms.Guna2Button();
            this.btnMascota = new Guna.UI2.WinForms.Guna2Button();
            this.btnRaza = new Guna.UI2.WinForms.Guna2Button();
            this.btnEspecie = new Guna.UI2.WinForms.Guna2Button();
            this.btnPropietario = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(182, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1102, 749);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnConsulta);
            this.panel3.Controls.Add(this.btnMascota);
            this.panel3.Controls.Add(this.btnRaza);
            this.panel3.Controls.Add(this.btnEspecie);
            this.panel3.Controls.Add(this.btnPropietario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 749);
            this.panel3.TabIndex = 13;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(-1, 533);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(182, 45);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Estadisticas";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "MY VET";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Animated = true;
            this.button4.AutoRoundedCorners = true;
            this.button4.BorderColor = System.Drawing.Color.Gray;
            this.button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button4.IndicateFocus = true;
            this.button4.Location = new System.Drawing.Point(-1, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 45);
            this.button4.TabIndex = 22;
            this.button4.Text = "IA";
            this.button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button4.TextOffset = new System.Drawing.Point(10, 0);
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 48);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Animated = true;
            this.button3.AutoRoundedCorners = true;
            this.button3.BorderColor = System.Drawing.Color.Gray;
            this.button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button3.IndicateFocus = true;
            this.button3.Location = new System.Drawing.Point(-1, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 45);
            this.button3.TabIndex = 21;
            this.button3.Text = "Especializacion";
            this.button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button3.TextOffset = new System.Drawing.Point(10, 0);
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Animated = true;
            this.button2.AutoRoundedCorners = true;
            this.button2.BorderColor = System.Drawing.Color.Gray;
            this.button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button2.IndicateFocus = true;
            this.button2.Location = new System.Drawing.Point(-1, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cita";
            this.button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button2.TextOffset = new System.Drawing.Point(10, 0);
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.AutoRoundedCorners = true;
            this.button1.BorderColor = System.Drawing.Color.Gray;
            this.button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button1.IndicateFocus = true;
            this.button1.Location = new System.Drawing.Point(-1, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Veterinario";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button1.TextOffset = new System.Drawing.Point(10, 0);
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Animated = true;
            this.btnConsulta.AutoRoundedCorners = true;
            this.btnConsulta.BorderColor = System.Drawing.Color.Gray;
            this.btnConsulta.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnConsulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsulta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConsulta.IndicateFocus = true;
            this.btnConsulta.Location = new System.Drawing.Point(-1, 278);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(182, 45);
            this.btnConsulta.TabIndex = 18;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConsulta.TextOffset = new System.Drawing.Point(10, 0);
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // btnMascota
            // 
            this.btnMascota.Animated = true;
            this.btnMascota.AutoRoundedCorners = true;
            this.btnMascota.BorderColor = System.Drawing.Color.Gray;
            this.btnMascota.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnMascota.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMascota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMascota.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnMascota.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMascota.ForeColor = System.Drawing.Color.Black;
            this.btnMascota.Image = ((System.Drawing.Image)(resources.GetObject("btnMascota.Image")));
            this.btnMascota.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMascota.IndicateFocus = true;
            this.btnMascota.Location = new System.Drawing.Point(-1, 227);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(182, 45);
            this.btnMascota.TabIndex = 17;
            this.btnMascota.Text = "Mascota";
            this.btnMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMascota.TextOffset = new System.Drawing.Point(10, 0);
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click_1);
            // 
            // btnRaza
            // 
            this.btnRaza.Animated = true;
            this.btnRaza.AutoRoundedCorners = true;
            this.btnRaza.BorderColor = System.Drawing.Color.Gray;
            this.btnRaza.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRaza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRaza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRaza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRaza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnRaza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRaza.ForeColor = System.Drawing.Color.Black;
            this.btnRaza.Image = ((System.Drawing.Image)(resources.GetObject("btnRaza.Image")));
            this.btnRaza.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRaza.IndicateFocus = true;
            this.btnRaza.Location = new System.Drawing.Point(-1, 176);
            this.btnRaza.Name = "btnRaza";
            this.btnRaza.Size = new System.Drawing.Size(182, 45);
            this.btnRaza.TabIndex = 16;
            this.btnRaza.Text = "Raza";
            this.btnRaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRaza.TextOffset = new System.Drawing.Point(10, 0);
            this.btnRaza.Click += new System.EventHandler(this.btnRaza_Click_1);
            // 
            // btnEspecie
            // 
            this.btnEspecie.Animated = true;
            this.btnEspecie.AutoRoundedCorners = true;
            this.btnEspecie.BorderColor = System.Drawing.Color.Gray;
            this.btnEspecie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEspecie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEspecie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEspecie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEspecie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnEspecie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEspecie.ForeColor = System.Drawing.Color.Black;
            this.btnEspecie.Image = ((System.Drawing.Image)(resources.GetObject("btnEspecie.Image")));
            this.btnEspecie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEspecie.IndicateFocus = true;
            this.btnEspecie.Location = new System.Drawing.Point(-1, 125);
            this.btnEspecie.Name = "btnEspecie";
            this.btnEspecie.Size = new System.Drawing.Size(182, 45);
            this.btnEspecie.TabIndex = 15;
            this.btnEspecie.Text = "Especie";
            this.btnEspecie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEspecie.TextOffset = new System.Drawing.Point(10, 0);
            this.btnEspecie.Click += new System.EventHandler(this.btnEspecie_Click_1);
            // 
            // btnPropietario
            // 
            this.btnPropietario.Animated = true;
            this.btnPropietario.AutoRoundedCorners = true;
            this.btnPropietario.BorderColor = System.Drawing.Color.Gray;
            this.btnPropietario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPropietario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPropietario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPropietario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPropietario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(245)))));
            this.btnPropietario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPropietario.ForeColor = System.Drawing.Color.Black;
            this.btnPropietario.Image = ((System.Drawing.Image)(resources.GetObject("btnPropietario.Image")));
            this.btnPropietario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPropietario.IndicateFocus = true;
            this.btnPropietario.Location = new System.Drawing.Point(-1, 74);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(182, 45);
            this.btnPropietario.TabIndex = 14;
            this.btnPropietario.Text = "Propietario";
            this.btnPropietario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPropietario.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnPropietario;
        private Guna.UI2.WinForms.Guna2Button btnEspecie;
        private Guna.UI2.WinForms.Guna2Button btnRaza;
        private Guna.UI2.WinForms.Guna2Button btnMascota;
        private Guna.UI2.WinForms.Guna2Button btnConsulta;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button3;
        private Guna.UI2.WinForms.Guna2Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

