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
    public partial class FrmEspecializacionAgregar : Form
    {
        IServiceEntidad<Especializacion> logEspecializacion = new logEspecializacion();
        public FrmEspecializacionAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    string message = agregar(Mappeo());
                    if (message.Contains("correctamente"))
                    {
                        MessageBox.Show(message, "Agregar Especializacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void salir()
        {
           this.Close();
        }
        private string agregar(Especializacion especialiacion)
        {
            try
            {
                return logEspecializacion.Guardar(especialiacion);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        private Especializacion Mappeo()
        {
            Especializacion especializacion = new Especializacion();
            especializacion.Nombre = txtNombre.Text;
            return especializacion;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentException("El nombre de la especie no puede estar vacío.");
            return true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
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
