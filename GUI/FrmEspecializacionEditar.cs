using System;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace ProyectoP3
{
    public partial class FrmEspecializacionEditar : Form
    {
        ICrud<Especializacion> logEspecializacion = new EspecializacionService();
        public FrmEspecializacionEditar(Especializacion especializacion)
        {
            InitializeComponent();
            mostrarEspecializacion(especializacion);
        }
        int codigo;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var mensaje = editar(Mapeo());
                    if (mensaje.Contains("correctamente"))
                    {
                        MessageBox.Show(mensaje, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salir()
        {
            this.Close();
        }

        private Especializacion Mapeo()
        {
            Especializacion especializacion = new Especializacion();
            especializacion.Codigo = codigo;
            especializacion.Nombre = txtNombre.Text;
            return especializacion;
        }

        private string editar(Especializacion especializacion)
        {
            try
            {
                return logEspecializacion.Actualizar(especializacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("El nombre de la especie no puede estar vacia.");
            return true;
        }
        private void mostrarEspecializacion(Especializacion especializacion)
        {
            txtNombre.Text = especializacion.Nombre;
            codigo = especializacion.Codigo;
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
