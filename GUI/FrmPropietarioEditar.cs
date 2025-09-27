using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEditarPropietatio : Form
    {
        public FrmEditarPropietatio(Propietario propietario)
        {
            InitializeComponent();
            mostrarPropietario(propietario);
            txtId.Enabled = false; // Deshabilitar el campo ID para evitar modificaciones
        }
        LogPropietario logPropietario = new LogPropietario();
        private void FrmEditarPropietatio_Load(object sender, EventArgs e)
        {
        }
        private void mostrarPropietario(Propietario propietario)
        {
            txtId.Text = propietario.Cedula.ToString();
            txtNombre.Text = propietario.Nombre;
            txtNumTlf.Text = propietario.Telefono;
            if (propietario.Sexo == "Femenino") RBFemenino.Checked = true;
            else RBMasculino.Checked = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var message = editar();
            MessageBox.Show(message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            salir();
        }

        private string editar()
        {
            try
            {
                string sexo;
                if (RBFemenino.Checked) sexo = "Femenino";
                else sexo = "Masculino";
                return logPropietario.Guardar(new Propietario(int.Parse(txtId.Text), txtNombre.Text, sexo, txtNumTlf.Text));
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
            return MessageBox.Show
             (
             $"¿Está seguro de que desea {accion}?",
             $"Confirmar {accion}",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
        }
    }
}
