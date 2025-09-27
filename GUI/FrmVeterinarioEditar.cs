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
    public partial class FrmVeterinarioEditar : Form
    {
        public FrmVeterinarioEditar(Veterinario veterinario)
        {
            InitializeComponent();
            mostrarVeterinario(veterinario);
        }

        LogVeterinario logVeterinario = new LogVeterinario();
        private void mostrarVeterinario(Veterinario veterinario)
        {
            txtId.Text = veterinario.Cedula.ToString();
            txtNombre.Text = veterinario.Nombre;
            txtNumTlf.Text = veterinario.Telefono;
            if (veterinario.Sexo == "Femenino") RBFemenino.Checked = true;
            else RBMasculino.Checked = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string message;
                message = editar(Mapeo());
                MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                salir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private string editar(Veterinario veterinario)
        {
            try
            {
                return logVeterinario.Actualizar(veterinario);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
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
        private Veterinario Mapeo()
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(txtId.Text);
            veterinario.Nombre = txtNombre.Text;
            veterinario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            veterinario.Telefono = txtNumTlf.Text;
            return veterinario;
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            if (string.IsNullOrEmpty(txtNumTlf.Text)) throw new ArgumentNullException("El campo Teléfono es obligatorio.");
            if (RBFemenino.Checked == false && RBMasculino.Checked == false) throw new ArgumentNullException("El campo Sexo es obligatorio.");
            return true;
        }
    }

}
