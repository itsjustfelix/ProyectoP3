using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmConsultaAgregar : Form
    {
        ICrud<Consulta> logConsulta;
        ICrud<Mascota> logMascota;
        IVeterinarioService logVeterinario;
        EspecializacionService logEspecializacion;
        public DialogResult resultado;
        public FrmConsultaAgregar()
        {
            InitializeComponent();
            SetControlesEstado(false);
            logConsulta = new ConsultaService();
            logMascota = new MascotaService();
            logVeterinario = new VeterinarioService();
            logEspecializacion = new EspecializacionService();
            lblNombreMascota.Text = "";
        }
        public FrmConsultaAgregar(Mascota mascota,Veterinario veterinario)
        {
            InitializeComponent();
            setEstado(false);
            logConsulta = new ConsultaService();
            logMascota = new MascotaService();
            logVeterinario = new VeterinarioService();
            logEspecializacion = new EspecializacionService();
            mostrarInformacion(mascota, veterinario);
        }
        
       
        private void FrmConsultaAgregar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecializacion();
        }
        
        private void cargarCmbVeterinario(int especializacion)
        {
            cbmVeterinario.DataSource = logVeterinario.buscarPorEspecializacion(especializacion);
            cbmVeterinario.DisplayMember = "Nombres";
            cbmVeterinario.ValueMember = "Cedula";
            cbmVeterinario.SelectedIndex = -1;
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecializacion.DisplayMember = "Nombre";
            cmbEspecializacion.ValueMember = "Codigo";
            cmbEspecializacion.DataSource = logEspecializacion.Consultar();
        }
        private void setEstado(bool estado)
        {
            txtIdMascota.Enabled = estado;
            btnBuscarMascota.Enabled = estado;
            cbmVeterinario.Enabled = estado;
            cmbEspecializacion.Enabled = estado;
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
            if (cbmVeterinario.SelectedIndex == -1) throw new Exception("Debe seleccionar un veterinario.");
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
        private Mascota buscarMascota(int id)
        {
            return logMascota.BuscarPorId(id);
        }
        private Veterinario buscarVeterinario(int id)
        {
            return logVeterinario.BuscarPorId(id);
        }
        private Consulta Mapeo()
        {
            Mascota mascota = buscarMascota(int.Parse(txtIdMascota.Text));
            Veterinario veterinario = buscarVeterinario(int.Parse(cbmVeterinario.SelectedValue.ToString()));
            Consulta consulta = new Consulta();
            consulta.Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
            consulta.Descripcion = txtDescripcion.Text;
            consulta.Diagnostico = txtDiagnostico.Text;
            consulta.Tratamiento = txtTratamiento.Text;
            consulta.Mascota = mascota;
            consulta.Veterinario = veterinario;
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
            cmbEspecializacion.Enabled = estado;
            cbmVeterinario.Enabled = estado;
            txtDescripcion.Enabled = estado;
            txtDiagnostico.Enabled = estado;
            txtTratamiento.Enabled = estado;
        }
        private void mostrarInformacion(Mascota mascota, Veterinario veterinario)
        {
            txtIdMascota.Text = mascota.Codigo.ToString();
            lblNombreMascota.Text = mascota.Nombre;
            cmbEspecializacion.SelectedValue = veterinario.Especializacion.Codigo;
            cargarCmbVeterinario(veterinario.Especializacion.Codigo);
            cbmVeterinario.SelectedValue = veterinario.Cedula;
        }

        private void cmbEspecializacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmbEspecializacion.SelectedIndex != -1)
                cargarCmbVeterinario(int.Parse(cmbEspecializacion.SelectedValue.ToString()));
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
                Mascota mascota = buscarMascota(int.Parse(txtIdMascota.Text));
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
    }
}
