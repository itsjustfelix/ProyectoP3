using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEspecieEditar : Form
    {
        ICrud<Especie> logEspecie;
        int codigo;
        public FrmEspecieEditar(Especie especie)
        {
            logEspecie = new EspecieService();
            InitializeComponent();
            mostrarEspecie(especie);
        }
       
        private bool editar(Especie especie)
        {
            try
            {
                return logEspecie.Actualizar(especie);
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
        private void mostrarEspecie(Especie especie)
        {
            txtNombre.Text = especie.Nombre;
            codigo = especie.Codigo;
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
        private void salir()
        {
            this.Close();
        }
        private Especie Mapeo()
        {
            Especie especie = new Especie();
            especie.Codigo = codigo;
            especie.Nombre = txtNombre.Text;
            return especie;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var mensaje = editar(Mapeo());
                    if (mensaje)
                    {
                        MessageBox.Show("Especie actualizada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo ub error al momento de actualizar la especie.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
        }
    }
}
