using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmEditarPropietatio : Form
    {
        public FrmEditarPropietatio(Propietario propietario)
        {
            InitializeComponent();
            mostrarPropietario(propietario);
            txtId.Enabled = false; // Deshabilitar el campo ID para evitar modificaciones
        }
        IServicePersonas<Propietario> logPropietario = new LogPropietario();
        private void FrmEditarPropietatio_Load(object sender, EventArgs e)
        {
        }
        private void mostrarPropietario(Propietario propietario)
        {
            txtId.Text = propietario.Cedula.ToString();
            txtNombre.Text = propietario.Nombre;
            txtNumTlf.Text = propietario.Telefono;
            if (propietario.Sexo == "Femenino") RBFemenino.Checked = true;
            else RBMasculino.Checked = true;
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

        private string editar(Propietario propietario)
        {
            try
            {
                return logPropietario.Guardar(propietario);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
        }
        private Propietario Mapeo()
        {
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(txtId.Text);
            propietario.Nombre = txtNombre.Text;
            propietario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            propietario.Telefono = txtNumTlf.Text;
            return propietario;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) throw new ArgumentException("La cédula no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentException("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(txtNumTlf.Text)) throw new ArgumentException("El número de teléfono no puede estar vacío.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentException("Debe seleccionar un sexo.");
            if (!int.TryParse(txtId.Text, out _)) throw new ArgumentException("La cédula debe ser un número válido.");
            return true;
        }
    }
}
