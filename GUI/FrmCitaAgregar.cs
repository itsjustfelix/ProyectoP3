using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmCitaAgregar : Form
    {
        public FrmCitaAgregar()
        {
            InitializeComponent();
        }
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        IServiceEntidad<Cita> logCita = new LogCita();
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
        private Mascota buscarMascota(string id)
        {
            return logMascota.BuscarPorId(id);
        }
        private void SetControlesEstado(bool estado)
        {
            DTPHora.Enabled = estado;
            DTPFecha.Enabled = estado;
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
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtIdMascota.Text)) throw new ArgumentNullException("Debe ingresar el codigo de la mascota.");
            if (DTPFecha.Value < DateTime.Now) throw new ArgumentException("La fecha de la cita no puede ser en el pasado.");
            if (DTPHora.Value.TimeOfDay < DateTime.Now.TimeOfDay && DTPFecha.Value.Date == DateTime.Now.Date) throw new ArgumentException("La hora de la cita no puede ser en el pasado.");
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = DialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) Salir();
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
        private void FrmCitaAgregar_Load(object sender, EventArgs e)
        {
            lblNombreMascota.Text = string.Empty;
        }

        private Cita Mapeo()
        {
            Mascota mascota = buscarMascota(txtIdMascota.Text);
            Cita cita = new Cita();
            cita.Mascota = mascota;
            cita.Fecha = DTPFecha.Value;
            cita.Hora = DTPHora.Value;
            return cita;
        }
    }
}
