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
            this.veterinario = veterinario;
        }
        Veterinario veterinario;
        IServicePersonas<Veterinario> logVeterinario = new LogVeterinario();
        IServiceEntidad<Especializacion> logEspecializacion = new logEspecializacion();
        private void mostrarVeterinario(Veterinario veterinario)
        {
            txtCedula.Text = veterinario.Cedula.ToString();
            txtNombre.Text = veterinario.Nombres;
            txtApellidoPaterno.Text = veterinario.ApellidoPaterno;
            txtApellidoMaterno.Text = veterinario.ApellidoMaterno;
            txtNumeroTelefonicoPrimario.Text = veterinario.Telefono;
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
            veterinario.Cedula = txtCedula.Text;
            veterinario.Nombres = txtNombre.Text;
            veterinario.ApellidoPaterno = txtApellidoPaterno.Text;
            veterinario.ApellidoMaterno = txtApellidoMaterno.Text;
            veterinario.Sexo = RBFemenino.Checked ? "F" : "M";
            veterinario.Telefono = txtNumeroTelefonicoPrimario.Text;
            veterinario.Especializacion = buscarEspecializacion(cmbEspecilizacion.SelectedValue.ToString());
            return veterinario;
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            if (string.IsNullOrEmpty(txtCedula.Text)) throw new ArgumentNullException("El campo Cedula es obligatorio.");
            if (string.IsNullOrEmpty(txtApellidoPaterno.Text)) throw new ArgumentNullException("El campo Apellido Paterno es obligatorio.");
            if (string.IsNullOrEmpty(txtApellidoMaterno.Text)) throw new ArgumentNullException("El campo Apellido Materno es obligatorio.");
            if (string.IsNullOrEmpty(txtNumeroTelefonicoPrimario.Text)) throw new ArgumentNullException("El campo Teléfono primarioes obligatorio.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentNullException("El campo Sexo es obligatorio.");
            return true;
        }
        private Especializacion buscarEspecializacion(string codigo)
        {
            return logEspecializacion.BuscarPorId(codigo);
        }
        private void FrmVeterinarioEditar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecializacion();
            mostrarVeterinario(veterinario);
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecilizacion.DataSource = logEspecializacion.Consultar();
            cmbEspecilizacion.DisplayMember = "Nombre";
            cmbEspecilizacion.ValueMember = "Codigo";
        }
    }

}
