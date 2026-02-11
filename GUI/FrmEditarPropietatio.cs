using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEditarPropietatio : Form
    {
        IPropietarioService logPropietario;
        Propietario propietario;
        public FrmEditarPropietatio(Propietario propietario)
        {
            InitializeComponent();
            logPropietario = new PropietarioService();
            this.propietario = propietario;
        }
        private void FrmEditarPropietatio_Load(object sender, EventArgs e)
        {
            mostrarPropietario(propietario);
            txtCedula.Enabled = false;
        }
        private void mostrarPropietario(Propietario propietario)
        {
            txtCedula.Text = propietario.Cedula.ToString();
            txtNombre.Text = propietario.NombreCompleto;
            txtNumeroTelefonicoPrimario.Text = propietario.Telefono;
            txtEmail.Text = propietario.Email;
            if (propietario.Sexo == "F") RBFemenino.Checked = true;
            else RBMasculino.Checked = true;
        }
        private bool editar(Propietario propietario)
        {
            try
            {
                return logPropietario.Actualizar(propietario);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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
        private Propietario Mapeo()
        {
            Propietario propietario = new Propietario();
            propietario.Cedula = txtCedula.Text;
            propietario.NombreCompleto = txtNombre.Text;
            propietario.Sexo = RBFemenino.Checked ? "F" : "M";
            propietario.Telefono = txtNumeroTelefonicoPrimario.Text;
            propietario.Email = txtEmail.Text;
            return propietario;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(txtNumeroTelefonicoPrimario.Text)) throw new ArgumentException("El número de teléfono no puede estar vacío.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentException("Debe seleccionar un sexo.");
            if (string.IsNullOrEmpty(txtEmail.Text)) throw new ArgumentException("El email no puede estar vacío.");
            return true;
        }
        private void salir()
        {
            this.Close();
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    if (message)
                    {
                        MessageBox.Show("Propietario editado con exito.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de editar el propietario. ", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNumeroTelefonicoPrimario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtNumeroTelefonicoPrimario.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
