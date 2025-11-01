using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEspecieEditar : Form
    {
        public FrmEspecieEditar(Especie especie)
        {
            InitializeComponent();
            mostrarEspecie(especie);
        }

        ICrud<Especie> logEspecie = new LogEspecie();
        string id;
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
        private string editar(Especie especie)
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
            id = especie.Codigo;
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
        private void salir()
        {
            this.Close();
        }
        private Especie Mapeo()
        {
            Especie especie = new Especie();
            especie.Codigo = id;
            especie.Nombre = txtNombre.Text;
            return especie;
        }

    }
}
