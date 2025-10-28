namespace ProyectoP3
{
    partial class FrmIA
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
            this.txtHistorial = new System.Windows.Forms.RichTextBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHistorial
            // 
            this.txtHistorial.Location = new System.Drawing.Point(9, 10);
            this.txtHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.ReadOnly = true;
            this.txtHistorial.Size = new System.Drawing.Size(560, 258);
            this.txtHistorial.TabIndex = 0;
            this.txtHistorial.Text = "";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(9, 288);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(319, 20);
            this.txtPregunta.TabIndex = 1;
            this.txtPregunta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPregunta_KeyDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(367, 288);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(56, 19);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(9, 331);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(29, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Listo";
            // 
            // FrmIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.txtHistorial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIA";
            this.Text = "FrmIA";
            this.Load += new System.EventHandler(this.FrmIA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHistorial;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblEstado;
    }
}