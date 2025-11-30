using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace ProyectoP3
{
    public partial class FrmConsultaMostrar : Form
    {
        Consulta Consulta;
        public FrmConsultaMostrar(Consulta consulta)
        {
            InitializeComponent();
            this.Consulta = consulta;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarTxt(Consulta consulta)
        {
            txtDescripcion.Text = consulta.Descripcion;
            txtDiagnostico.Text = consulta.Diagnostico;
            txtTratamiento.Text = consulta.Tratamiento;
            txtFecha.Text = consulta.Fecha;
            txtNombreMascota.Text = consulta.Mascota.Nombre;
            txtVeterinario.Text = consulta.Veterinario.Nombres;

        }
        private void FrmConsultaMostrar_Load(object sender, EventArgs e)
        {
            cargarTxt(Consulta);
        }
    }
}
