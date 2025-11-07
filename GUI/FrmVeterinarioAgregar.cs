using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmVeterinarioAgregar : Form
    {
        IServiceVeterinario logVeterinario;
        ICrud<Especializacion> logEspecializacion;
        public FrmVeterinarioAgregar()
        {
            InitializeComponent();
            logVeterinario = new VeterinarioService();
            logEspecializacion = new EspecializacionService();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var mensaje = agregar(Mapeo());
                    if (mensaje.Contains("Guardado"))
                    {
                        MessageBox.Show(mensaje, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
                salir();
            
        }
        private void FrmVeterinarioAgregar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecializacion();
        }

        private void cargarCmbEspecializacion()
        {
            cmbEspecilizacion.DataSource = logEspecializacion.Consultar();
            cmbEspecilizacion.DisplayMember = "Nombre";
            cmbEspecilizacion.ValueMember = "Codigo";
        }
        private string agregar(Veterinario veterinario)
        {
            try
            {
                return logVeterinario.Guardar(veterinario);
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
        private Especializacion buscarEspecializacion(int codigo)
        {
            return logEspecializacion.BuscarPorId(codigo);
        }
        private void salir()
        {
            this.Close();
        }
        private Veterinario Mapeo()
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(txtCedula.Text);
            veterinario.Nombres = txtNombre.Text;
            veterinario.ApellidoPaterno = txtApellidoPaterno.Text;
            veterinario.ApellidoMaterno = txtApellidoMaterno.Text;
            veterinario.Sexo = RBFemenino.Checked ? "F" : "M";
            veterinario.Telefono = txtNumeroTelefonicoPrimario.Text;
            veterinario.Especializacion = buscarEspecializacion(int.Parse(cmbEspecilizacion.SelectedValue.ToString()));
            return veterinario;
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtCedula.Text)) throw new ArgumentNullException("El campo Cédula es obligatorio.");
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            if (string.IsNullOrEmpty(txtApellidoPaterno.Text)) throw new ArgumentNullException("El campo Apellido Paterno es obligatorio.");
            if (string.IsNullOrEmpty(txtApellidoMaterno.Text)) throw new ArgumentNullException("El campo Apellido Materno es obligatorio.");
            if (string.IsNullOrEmpty(txtNumeroTelefonicoPrimario.Text)) throw new ArgumentNullException("El campo Teléfono primario es obligatorio.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentNullException("El campo Sexo es obligatorio.");
            return true;
        }
    }
}
