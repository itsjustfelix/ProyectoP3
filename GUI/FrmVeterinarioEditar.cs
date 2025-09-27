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
            string message;
            message = editar();
            MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            salir();
        }
        private string editar()
        {
            try
            {
                string sexo;
                if (RBFemenino.Checked) sexo = "Femenino";
                else sexo = "Masculino";
                return logVeterinario.Actualizar(new Veterinario(int.Parse(txtId.Text), txtNombre.Text, sexo, txtNumTlf.Text));
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
    }

}
