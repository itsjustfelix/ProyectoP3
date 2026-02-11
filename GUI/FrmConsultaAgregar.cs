using Entidad;
using Logica;
using System;
using System.Windows.Forms;

namespace ProyectoP3
{
    public partial class FrmConsultaAgregar : Form
    {
        IConsultaService logConsulta;
        IMascotaService logMascota;
        IVeterinarioService logVeterinario;
        public DialogResult resultado;
        string cedulaVeterinario;
        string codigoMascota;
        public FrmConsultaAgregar()
        {
            InitializeComponent();
            SetControlesEstado(false);
            logConsulta = new ConsultaService();
            logMascota = new MascotaService();
            logVeterinario = new VeterinarioService();
            lblNombreMascota.Text = "";
        }
        public FrmConsultaAgregar(string codigoMascota, string cedulaVeterinario)
        {
            InitializeComponent();
            setEstado(false);
            logConsulta = new ConsultaService();
            logMascota = new MascotaService();
            logVeterinario = new VeterinarioService();
            this.codigoMascota = codigoMascota;
            this.cedulaVeterinario = cedulaVeterinario;
        }


        private void FrmConsultaAgregar_Load(object sender, EventArgs e)
        {
            var mascota = buscarMascota(codigoMascota);
            var veterinario = buscarVeterinario(cedulaVeterinario);
            mostrarInformacion(mascota, veterinario);
        }



        private void setEstado(bool estado)
        {
            txtIdMascota.Enabled = estado;
        }
        private void salir()
        {
            this.Close();
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtDiagnostico.Text)) throw new Exception("El campo Diagnóstico es obligatorio.");
            if (string.IsNullOrEmpty(txtTratamiento.Text)) throw new Exception("El campo Tratamiento es obligatorio.");
            if (string.IsNullOrEmpty(txtDescripcion.Text)) throw new Exception("El campo Descripción es obligatorio.");
            return true;
        }
        private bool agregar(Consulta consulta)
        {
            try
            {
                return logConsulta.Guardar(consulta);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al agregar la consulta: {e.Message}", e);
            }

        }
        private MascotaDTO buscarMascota(string id)
        {
            return logMascota.buscar(id);
        }
        private VeterinarioDTO buscarVeterinario(string id)
        {
            return logVeterinario.buscar(id);
        }
        private Consulta Mapeo()
        {
            Consulta consulta = new Consulta();
            consulta.Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
            consulta.Descripcion = txtDescripcion.Text;
            consulta.Diagnostico = txtDiagnostico.Text;
            consulta.Tratamiento = txtTratamiento.Text;
            consulta.MascotaCodigo = txtIdMascota.Text;
            consulta.VeterinarioCedula = cedulaVeterinario;
            return consulta;
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
        private void SetControlesEstado(bool estado)
        {
            txtDescripcion.Enabled = estado;
            txtDiagnostico.Enabled = estado;
            txtTratamiento.Enabled = estado;
        }
        private void mostrarInformacion(MascotaDTO mascota, VeterinarioDTO veterinario)
        {
            txtIdMascota.Text = mascota.Codigo.ToString();
            lblNombreMascota.Text = mascota.Nombre;
            txtVeterinario.Text = veterinario.NombreCompleto;
            txtEspecializacion.Text = veterinario.NombreEspecializacion;
            cedulaVeterinario = veterinario.Cedula;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = agregar(Mapeo());
                    if (message)
                    {
                        MessageBox.Show("Consulta guardada correcctamente.", "Agregar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultado = DialogResult.OK;
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de guardar la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBuscarMascota_Click_1(object sender, EventArgs e)
        {
            try
            {
                MascotaDTO mascota = buscarMascota(txtIdMascota.Text);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Buscar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNombreMascota.Text = "";
                    SetControlesEstado(false);
                    return;
                }
                lblNombreMascota.Text = mascota.Nombre;
                SetControlesEstado(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtVeterinario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
