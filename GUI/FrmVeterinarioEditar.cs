using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmVeterinarioEditar : Form
    {
        public FrmVeterinarioEditar(Veterinario veterinario)
        {
            InitializeComponent();
            mostrarVeterinario(veterinario);
        }

        IServicePersonas<Veterinario> logVeterinario = new LogVeterinario();
        IServiceEntidad<Especializacion> logEspecializacion = new logEspecializacion();
        private void mostrarVeterinario(Veterinario veterinario)
        {
            txtId.Text = veterinario.Cedula.ToString();
            txtNombre.Text = veterinario.Nombre;
            txtNumTlf.Text = veterinario.Telefono;
            if (veterinario.Sexo == "Femenino") RBFemenino.Checked = true;
            else RBMasculino.Checked = true;
            cmbEspecilizacion.SelectedValue = veterinario.Especializacion.Codigo;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    string message;
                    message = editar(Mapeo());
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
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private string editar(Veterinario veterinario)
        {
            try
            {
                return logVeterinario.Actualizar(veterinario);
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
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
        private Veterinario Mapeo()
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(txtId.Text);
            veterinario.Nombre = txtNombre.Text;
            veterinario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            veterinario.Telefono = txtNumTlf.Text;
            veterinario.Especializacion = buscarEspecializacion(int.Parse(cmbEspecilizacion.SelectedValue.ToString()));
            return veterinario;
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            if (string.IsNullOrEmpty(txtNumTlf.Text)) throw new ArgumentNullException("El campo Teléfono es obligatorio.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentNullException("El campo Sexo es obligatorio.");
            return true;
        }
        private Especializacion buscarEspecializacion(int codigo)
        {
            return logEspecializacion.BuscarPorId(codigo);
        }
        private void FrmVeterinarioEditar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecializacion();
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecilizacion.DataSource = logEspecializacion.Consultar();
            cmbEspecilizacion.DisplayMember = "Nombre";
            cmbEspecilizacion.ValueMember = "Codigo";
        }
    }

}
