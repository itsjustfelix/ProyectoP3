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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPropietario());
        }

        private void btnEspecie_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEspecie());
        }

        private void btnRaza_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRaza());
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMascota());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsulta());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmVeterinario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCita());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEspecializacion());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmIA());
        }
    }
}
