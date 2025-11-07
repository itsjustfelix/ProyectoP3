using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEditarPropietatio : Form
    {
        ICrud<Propietario> logPropietario;
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    if (message.Contains("correctamente"))
                    {
                        MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
        }

        private void mostrarPropietario(Propietario propietario)
        {
            txtCedula.Text = propietario.Cedula.ToString();
            txtNombre.Text = propietario.Nombres;
            txtApellidoPaterno.Text = propietario.ApellidoPaterno;
            txtApellidoMaterno.Text = propietario.ApellidoMaterno;
            txtNumeroTelefonicoPrimario.Text = propietario.Telefono;
            txtEmail.Text = propietario.Email;
            if (propietario.Sexo == "F") RBFemenino.Checked = true;
            else RBMasculino.Checked = true;
        }
        private string editar(Propietario propietario)
        {
            try
            {
                return logPropietario.Actualizar(propietario);
            }
            catch (Exception e)
            {
                return e.Message;
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
            propietario.Cedula = int.Parse(txtCedula.Text);
            propietario.Nombres = txtNombre.Text;
            propietario.ApellidoPaterno = txtApellidoPaterno.Text;
            propietario.ApellidoMaterno = txtApellidoMaterno.Text;
            propietario.Sexo = RBFemenino.Checked ? "F" : "M";
            propietario.Telefono = txtNumeroTelefonicoPrimario.Text;
            propietario.Email = txtEmail.Text;
            return propietario;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text)) throw new ArgumentException("El apellido paterno no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text)) throw new ArgumentException("El apellido materno no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(txtNumeroTelefonicoPrimario.Text)) throw new ArgumentException("El número de teléfono no puede estar vacío.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentException("Debe seleccionar un sexo.");
            if (string.IsNullOrEmpty(txtEmail.Text)) throw new ArgumentException("El email no puede estar vacío.");
            return true;
        }
        private void salir()
        {
            this.Close();
        }
    }
}
