using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEspecieAgregar : Form
    {
        ICrud<Especie> especieService;
        public FrmEspecieAgregar()
        {
            InitializeComponent();
            especieService = new EspecieService();
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
        private bool agregar(Especie especie)
        {
            try
            {
                return especieService.Guardar(especie);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al agregar la especie: {e.Message}", e);
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (validar())
                {
                    var message = agregar(Mappeo());
                    if (message)
                    {
                        MessageBox.Show("Especie guardada correctamente.", "Agregar Especie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de guardar la especie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
        }
    }
}
