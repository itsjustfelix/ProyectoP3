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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHistorial
            // 
            this.txtHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistorial.Location = new System.Drawing.Point(9, 10);
            this.txtHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.ReadOnly = true;
            this.txtHistorial.Size = new System.Drawing.Size(1082, 472);
            this.txtHistorial.TabIndex = 0;
            this.txtHistorial.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(1022, 534);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(56, 33);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(33, 627);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(29, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Listo";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(11, 504);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(984, 63);
            this.txtPregunta.TabIndex = 1;
            this.txtPregunta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPregunta_KeyDown);
            // 
            // FrmIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 690);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.txtHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIA";
            this.Text = "FrmIA";
            this.Load += new System.EventHandler(this.FrmIA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHistorial;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtPregunta;
    }
}