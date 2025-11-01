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
    public partial class FrmEspecieAgregar : Form
    {
        public FrmEspecieAgregar()
        {
            InitializeComponent();
        }

        ICrud<Especie> logEspecie = new LogEspecie();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (validar())
                {
                    string message = agregar(Mappeo());
                    if (message.Contains("correctamente"))
                    {
                        MessageBox.Show(message, "Agregar Especie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
        }

        private void salir()
        {
            this.Close();
        }

        private bool validar()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentException("El nombre de la especie no puede estar vacío.");
            return true;
        }

        private string agregar(Especie especie)
        {
            try
            {
                return logEspecie.Guardar(especie);
            }
            catch (Exception e)
            {
                return e.Message;
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

        private Especie Mappeo()
        {
            Especie especie = new Especie();
            especie.Nombre = txtNombre.Text;
            return especie;
        }

    }
}
