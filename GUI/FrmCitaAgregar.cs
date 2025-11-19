using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmCitaAgregar : Form
    {
        MascotaService mascotaService;
        ICrud<Cita> citaService;
        IVeterinarioService veterinarioService;
        ICrud<Especializacion> especializacionService;
        ICrud<Propietario> propietarioService;
        public FrmCitaAgregar()
        {
            InitializeComponent();
            mascotaService = new MascotaService();
            citaService = new CitaService();
            veterinarioService = new VeterinarioService();
            especializacionService = new EspecializacionService();
            propietarioService = new PropietarioService();
        }
        private void FrmCitaAgregar_Load(object sender, EventArgs e)
        {
            lblNombrePropietario.Text = string.Empty;
            cargarCmbEspecializacion();
            SetControlesEstado(false);
        }
         
        private void cargarCmbVeterinario(int especialializacion)
        {
            cmbVeterianrio.DataSource = null;
            cmbVeterianrio.DataSource = veterinarioService.buscarPorEspecializacion(especialializacion);
            cmbVeterianrio.DisplayMember = "Nombres";
            cmbVeterianrio.ValueMember = "Cedula";
            cmbVeterianrio.SelectedIndex = -1;
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
        private bool Agregar(Cita cita)
        {
            try
            {
                return citaService.Guardar(cita);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Mascota buscarMascota(int id)
        {
            return mascotaService.buscar(id);
        }
        private void SetControlesEstado(bool estado)
        {
            DTPHora.Enabled = estado;
            DTPFecha.Enabled = estado;
            cmbEspecializacion.Enabled = estado;
            cmbVeterianrio.Enabled = estado;
            cmbMascotas.Enabled = estado; 
        }
        private Veterinario buscarVeterinario(int id)
        {
            return veterinarioService.buscar(id);
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecializacion.DataSource = null;
            cmbEspecializacion.DisplayMember = "Nombre";
            cmbEspecializacion.ValueMember = "Codigo";
            cmbEspecializacion.DataSource = especializacionService.Consultar();
            cmbEspecializacion.SelectedIndex = -1;
        }
        private Cita Mapeo()
        {
            Cita cita = new Cita();
            cita.Mascota = buscarMascota(int.Parse(cmbMascotas.SelectedValue.ToString()));
            cita.Fecha = DTPFecha.Value.ToString("dd/MM/yyyy");
            cita.Hora = DTPHora.Value.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            cita.Veterinario = buscarVeterinario(int.Parse(cmbVeterianrio.SelectedValue.ToString()));
            return cita;
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCedulaPropietario.Text)) throw new ArgumentNullException("Debe ingresar el codigo de la mascota.");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                if (Validar())
                {
                    var mensaje = Agregar(Mapeo());
                    if (mensaje)
                    {
                        MessageBox.Show("Cita guardada correctamente.", "Agregar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salir();
                    }
                    else MessageBox.Show("Hubo un error al momento de guardar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = DialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) Salir();
        }
        private Propietario buscarPropietario(int cedula)
        {
            return propietarioService.buscar(cedula);
        }
        private void cargarCmbMascotas(List<Mascota> lista)
        {
            cmbMascotas.DataSource = lista;
            cmbMascotas.DisplayMember = "Nombre";
            cmbMascotas.ValueMember = "Codigo";
            cmbMascotas.SelectedIndex = -1;
        }
        private void btnBuscarMascota_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txtCedulaPropietario.Text == "")
                {
                    MessageBox.Show("Debe introducir una cedula", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var propietario = buscarPropietario(int.Parse(txtCedulaPropietario.Text));
                if(propietario == null)
                {
                    MessageBox.Show("No se encontro ningun propietario con esa cedula", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                lblNombrePropietario.Text = $"{propietario.Nombres} {propietario.ApellidoPaterno}";
                cargarCmbMascotas(mascotaService.BuscarPorPropietario(propietario.Cedula));
                SetControlesEstado(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
