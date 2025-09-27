namespace ProyectoP3
{
    partial class FrmMascotaAgregar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.bttnBuscarProp = new System.Windows.Forms.Button();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.txtIdProprietario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreProp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.bttnBuscarProp);
            this.groupBox1.Controls.Add(this.cmbRaza);
            this.groupBox1.Controls.Add(this.cmbEspecie);
            this.groupBox1.Controls.Add(this.txtIdProprietario);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombreProp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(174, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(49, 207);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 33);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bttnBuscarProp
            // 
            this.bttnBuscarProp.Location = new System.Drawing.Point(232, 45);
            this.bttnBuscarProp.Name = "bttnBuscarProp";
            this.bttnBuscarProp.Size = new System.Drawing.Size(106, 23);
            this.bttnBuscarProp.TabIndex = 5;
            this.bttnBuscarProp.Text = "Buscar Propietario";
            this.bttnBuscarProp.UseVisualStyleBackColor = true;
            this.bttnBuscarProp.Click += new System.EventHandler(this.bttnBuscarProp_Click);
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(131, 158);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(180, 21);
            this.cmbRaza.TabIndex = 4;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(131, 125);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(180, 21);
            this.cmbEspecie.TabIndex = 4;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // txtIdProprietario
            // 
            this.txtIdProprietario.Location = new System.Drawing.Point(131, 15);
            this.txtIdProprietario.Name = "txtIdProprietario";
            this.txtIdProprietario.Size = new System.Drawing.Size(180, 20);
            this.txtIdProprietario.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombreProp
            // 
            this.lblNombreProp.AutoSize = true;
            this.lblNombreProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProp.Location = new System.Drawing.Point(46, 48);
            this.lblNombreProp.Name = "lblNombreProp";
            this.lblNombreProp.Size = new System.Drawing.Size(125, 16);
            this.lblNombreProp.TabIndex = 0;
            this.lblNombreProp.Text = "Nombre Propietario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Propietario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Especie";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nombre.Location = new System.Drawing.Point(24, 97);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(65, 20);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // FrmMascotaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMascotaAgregar";
            this.Text = "FrmMascotaAgregar";
            this.Load += new System.EventHandler(this.FrmMascotaAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnBuscarProp;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.TextBox txtIdProprietario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreProp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}