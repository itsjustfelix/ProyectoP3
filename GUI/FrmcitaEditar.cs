using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmcitaEditar : Form
    {
        public FrmcitaEditar(Cita cita)
        {
            InitializeComponent();
            mostrarCita(cita);
            SetEstadoControles(false);
        }
        IServiceEntidad<Cita> logCita = new LogCita();
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        int idCita;
        private void mostrarCita(Cita cita)
        {
            txtIdMascota.Text = cita.Mascota.Codigo.ToString();
            lblNombreMascota.Text = cita.Mascota.Nombre;
            DTPFecha.Value = cita.Fecha;
            DTPHora.Value = cita.Hora;
            idCita = cita.Codigo;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    var message = Editar(Mapeo());
                    if (message.Contains("correctamente"))
                    {
                        MessageBox.Show(message, "Editar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Salir();
                    }
                    else
                    {
                        MessageBox.Show(message, "Editar Cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private string Editar(Cita cita)
        {
            try
            {
                return logCita.Actualizar(cita);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private Mascota buscarMascota(int id)
        {
            return logMascota.BuscarPorId(id);
        }
        private void Salir()
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) Salir();
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
        private Cita Mapeo()
        {
            Mascota mascota = buscarMascota(int.Parse(txtIdMascota.Text));
            Cita cita = new Cita();
            cita.Codigo = idCita;
            cita.Mascota = mascota;
            cita.Fecha = DTPFecha.Value;
            cita.Hora = DTPHora.Value;
            return cita;
        }

        private void SetEstadoControles(bool estado)
        {
            txtIdMascota.Enabled = estado;
        }
    }
}
