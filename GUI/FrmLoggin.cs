using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoP3
{
    public partial class FrmLoggin : Form
    {
        public FrmLoggin()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                Form1 frmPrincipal = new Form1();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
