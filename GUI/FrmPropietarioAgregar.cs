using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmPropietarioAgregar : Form
    {
        ICrud<Propietario> propietarioService;
        public FrmPropietarioAgregar()
        {
            InitializeComponent();
            propietarioService = new PropietarioService();
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
        private bool agregar(Propietario propietario)
        {
            try
            {
                return propietarioService.Guardar(propietario);
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }

        }
        private Propietario Mappeo()
        {
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(txtId.Text);
            propietario.Nombres = txtNombre.Text;
            propietario.ApellidoPaterno = txtApellidoPaterno.Text;
            propietario.ApellidoMaterno = txtApellidoMaterno.Text;
            propietario.Sexo = RBFemenino.Checked ? "F" : "M";
            propietario.Telefono = txtNumeroTelefonoPrimario.Text;
            propietario.Email = txtEmail.Text;
            return propietario;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) throw new ArgumentNullException("La cédula es obligatoria.");
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentNullException("El nombre del propietario es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text)) throw new ArgumentNullException("El apellido paterno es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text)) throw new ArgumentNullException("El apellido materno es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtNumeroTelefonoPrimario.Text)) throw new ArgumentNullException("El número de teléfono primario es obligatorio.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentException("Debe seleccionar un género.");
            if (string.IsNullOrEmpty(txtEmail.Text)) throw new ArgumentNullException("El email es obligatorio.");
            return true;
        }
        private void salir()
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (validar())
                {
                    var mensaje = agregar(Mappeo());
                    if (mensaje)
                    {
                        MessageBox.Show("Propietario guardado con exito.", "Agregar Propietario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de guardar el propietario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (respuesta == DialogResult.Yes)
                salir();
        }

        private void RBMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
