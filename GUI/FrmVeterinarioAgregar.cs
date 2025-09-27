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
using Logica;

namespace ProyectoP3
{
    public partial class FrmVeterinarioAgregar : Form
    {
        public FrmVeterinarioAgregar()
        {
            InitializeComponent();
        }
        LogVeterinario logVeterinario = new LogVeterinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var message = agregar(Mapeo());
            MessageBox.Show(message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            salir();
        }
        private string agregar(Veterinario veterinario)
        {
            try
            {
                return logVeterinario.Guardar(veterinario);
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        private void salir()
        {
            this.Close();
        }
        private DialogResult dialogoPregunta(string accion)
        {
            return MessageBox.Show(
             $"¿Está seguro de que desea {accion}?",
             $"Confirmar {accion}",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
        }
        private Veterinario Mapeo()
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(txtId.Text);
            veterinario.Nombre = txtNombre.Text;
            veterinario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            veterinario.Telefono = txtNumTlf.Text;
            return veterinario;
        }
    }
}
