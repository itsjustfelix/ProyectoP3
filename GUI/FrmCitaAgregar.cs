using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmCitaAgregar : Form
    {
        ICrud<Mascota> logMascota;
        ICrud<Cita> logCita;
        IServiceVeterinario logVeterinario;
        ICrud<Especializacion> logEspecializacion;
        public FrmCitaAgregar()
        {
            InitializeComponent();
            logMascota = new LogMascota();
            logCita = new LogCita();
            logVeterinario = new LogVeterinario();
            logEspecializacion = new logEspecializacion();
        }
        private void FrmCitaAgregar_Load(object sender, EventArgs e)
        {
            lblNombreMascota.Text = string.Empty;
            cargarCmbEspecializacion();
            SetControlesEstado(false);
        }
        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota mascota = buscarMascota(txtIdMascota.Text);
                if (mascota == null)
                {
                    MessageBox.Show("Mascota no encontrada", "Buscar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNombreMascota.Text = string.Empty;
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    var mensaje = Agregar(Mapeo());
                    if (mensaje.Contains("Guardado"))
                    {
                        MessageBox.Show(mensaje, "Agregar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salir();
                    }
                    else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = DialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) Salir();
        }
        private void cmbEspecializacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEspecializacion.SelectedIndex != -1) { cargarCmbVeterinario(cmbEspecializacion.SelectedValue.ToString());}  
        }


        private void cargarCmbVeterinario(string especialializacion)
        {
            cmbVeterianrio.DataSource = null;
            cmbVeterianrio.DataSource = logVeterinario.BuscarPorCualidad(especialializacion);
            cmbVeterianrio.DisplayMember = "Nombres";
            cmbVeterianrio.ValueMember = "Cedula";
            cmbVeterianrio.SelectedIndex = -1;
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecializacion.DataSource = null;
            cmbEspecializacion.DataSource = logEspecializacion.Consultar();
            cmbEspecializacion.DisplayMember = "Nombre";
            cmbEspecializacion.ValueMember = "Codigo";
            cmbEspecializacion.SelectedIndex = -1;
        }
        private DialogResult DialogoPregunta(string accion)
        {
            return MessageBox.Show(
             $"¿Está seguro de que desea {accion}?",
             $"Confirmar {accion}",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );
        }
        private Cita Mapeo()
        {
            Mascota mascota = buscarMascota(txtIdMascota.Text);
            Cita cita = new Cita();
            cita.Mascota = mascota;
            cita.Fecha = DTPFecha.Value;
            cita.Hora = DTPHora.Value;
            cita.Veterinario = buscarVeterinario(cmbVeterianrio.SelectedValue.ToString());
            return cita;
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtIdMascota.Text)) throw new ArgumentNullException("Debe ingresar el codigo de la mascota.");
            if (DTPFecha.Value < DateTime.Now) throw new ArgumentException("La fecha de la cita no puede ser en el pasado.");
            if (DTPHora.Value.TimeOfDay < DateTime.Now.TimeOfDay && DTPFecha.Value.Date == DateTime.Now.Date) throw new ArgumentException("La hora de la cita no puede ser en el pasado.");
            if (cmbEspecializacion.SelectedIndex == -1) throw new ArgumentException("Debe seleccionar una especializacion.");
            if (cmbVeterianrio.SelectedIndex == -1) throw new ArgumentException("Debe seleccionar un veterinario.");
            return true;
        }
        private void Salir()
        {
            this.Close();
        }
        private string Agregar(Cita cita)
        {
            try
            {
                return logCita.Guardar(cita);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private Mascota buscarMascota(string id)
        {
            return logMascota.BuscarPorId(id);
        }
        private void SetControlesEstado(bool estado)
        {
            DTPHora.Enabled = estado;
            DTPFecha.Enabled = estado;
            cmbEspecializacion.Enabled = estado;
            cmbVeterianrio.Enabled = estado;
        }
        private Veterinario buscarVeterinario(string id)
        {
            return logVeterinario.BuscarPorId(id);
        }

    }
}
