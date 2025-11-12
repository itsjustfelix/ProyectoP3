using System;
using System.Globalization;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmcitaEditar : Form
    {
        ICrud<Cita> logCita;
        ICrud<Mascota> logMascota;
        IServiceVeterinario logVeterinario;
        ICrud<Especializacion> logEspecializacion;
        Cita Cita;
        public FrmcitaEditar(Cita cita)
        {
            InitializeComponent();
            this.Cita = cita;
            logVeterinario = new VeterinarioService();
            logCita = new CitaService();
            logMascota = new MascotaService();
            logEspecializacion = new EspecializacionService();
        }
        private void FrmcitaEditar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecializacion();
            mostrarCita(Cita);
            SetEstadoControles(false);
        }
        
     
        
        private void mostrarCita(Cita cita)
        {
            txtIdMascota.Text = cita.Mascota.Codigo.ToString();
            lblNombreMascota.Text = cita.Mascota.Nombre;
            DTPFecha.Value = DateTime.ParseExact(cita.Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DTPHora.Value = DateTime.ParseExact(cita.Hora, "hh:mm tt", CultureInfo.InvariantCulture);
            cmbEspecializacion.SelectedValue = cita.Veterinario.Especializacion.Codigo;
            cmbVeterinario.SelectedValue = cita.Veterinario.Cedula;
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecializacion.DataSource = null;
            cmbEspecializacion.DataSource = logEspecializacion.Consultar();
            cmbEspecializacion.DisplayMember = "Nombre";
            cmbEspecializacion.ValueMember = "Codigo";
        }
        private void cargarCmbVeterinario(int especialializacion)
        {
            cmbVeterinario.DataSource = null;
            cmbVeterinario.DataSource = logVeterinario.BuscarPorCualidad(especialializacion);
            cmbVeterinario.DisplayMember = "Nombres";
            cmbVeterinario.ValueMember = "Cedula";
            cmbEspecializacion.SelectedIndex = -1;
        }
        private bool Editar(Cita cita)
        {
            try
            {
                return logCita.Actualizar(cita);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Mascota buscarMascota(int id)
        {
            return logMascota.BuscarPorId(id);
        }
        private Veterinario buscarVeterinario(int cedula)
        {
            return logVeterinario.BuscarPorId(cedula);
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
        private void SetEstadoControles(bool estado)
        {
            txtIdMascota.Enabled = estado;
        }
        private void Salir()
        {
            this.Close();
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtIdMascota.Text)) throw new ArgumentNullException("Debe ingresar el codigo de la mascota.");
            if (DTPFecha.Value < DateTime.Now) throw new ArgumentException("La fecha de la cita no puede ser en el pasado.");
            if (DTPHora.Value.TimeOfDay < DateTime.Now.TimeOfDay && DTPFecha.Value.Date == DateTime.Now.Date) throw new ArgumentException("La hora de la cita no puede ser en el pasado.");
            if (cmbEspecializacion.SelectedIndex == -1) throw new ArgumentException("Debe seleccionar una especializacion.");
            if (cmbVeterinario.SelectedIndex == -1) throw new ArgumentException("Debe seleccionar un veterinario.");
            return true;
        }
        private Cita Mapeo()
        {
            Cita cita = new Cita();
            cita.Codigo = this.Cita.Codigo;
            cita.Mascota = buscarMascota(int.Parse(txtIdMascota.Text));
            cita.Fecha = DTPFecha.Value.ToString("dd/MM/yyyy");
            cita.Hora = DTPHora.Value.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            cita.Veterinario = buscarVeterinario(int.Parse(cmbVeterinario.SelectedValue.ToString()));
            return cita;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEspecializacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarCmbVeterinario(int.Parse(cmbEspecializacion.SelectedValue.ToString()));
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    var message = Editar(Mapeo());
                    if (message)
                    {
                        MessageBox.Show("Cita actualizada correctamente.", "Editar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error a la hora de editar la cita.", "Editar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (respuesta == DialogResult.Yes) Salir();
        }
    }
}