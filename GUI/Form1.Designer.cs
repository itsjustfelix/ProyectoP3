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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnMascota = new System.Windows.Forms.Button();
            this.btnRaza = new System.Windows.Forms.Button();
            this.btnEspecie = new System.Windows.Forms.Button();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btnMascota);
            this.panel1.Controls.Add(this.btnRaza);
            this.panel1.Controls.Add(this.btnEspecie);
            this.panel1.Controls.Add(this.btnPropietario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 490);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cita";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Veterinario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(12, 176);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnMascota
            // 
            this.btnMascota.Location = new System.Drawing.Point(12, 147);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(75, 23);
            this.btnMascota.TabIndex = 3;
            this.btnMascota.Text = "Mascota";
            this.btnMascota.UseVisualStyleBackColor = true;
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click);
            // 
            // btnRaza
            // 
            this.btnRaza.Location = new System.Drawing.Point(12, 118);
            this.btnRaza.Name = "btnRaza";
            this.btnRaza.Size = new System.Drawing.Size(75, 23);
            this.btnRaza.TabIndex = 2;
            this.btnRaza.Text = "Raza";
            this.btnRaza.UseVisualStyleBackColor = true;
            this.btnRaza.Click += new System.EventHandler(this.btnRaza_Click);
            // 
            // btnEspecie
            // 
            this.btnEspecie.Location = new System.Drawing.Point(12, 89);
            this.btnEspecie.Name = "btnEspecie";
            this.btnEspecie.Size = new System.Drawing.Size(75, 23);
            this.btnEspecie.TabIndex = 1;
            this.btnEspecie.Text = "Especie";
            this.btnEspecie.UseVisualStyleBackColor = true;
            this.btnEspecie.Click += new System.EventHandler(this.btnEspecie_Click);
            // 
            // btnPropietario
            // 
            this.btnPropietario.Location = new System.Drawing.Point(12, 60);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(75, 23);
            this.btnPropietario.TabIndex = 0;
            this.btnPropietario.Text = "Propietario";
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(102, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(825, 490);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPropietario;
        private System.Windows.Forms.Button btnMascota;
        private System.Windows.Forms.Button btnRaza;
        private System.Windows.Forms.Button btnEspecie;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}

