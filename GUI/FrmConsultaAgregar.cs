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
    public partial class FrmConsultaAgregar : Form
    {
        public FrmConsultaAgregar()
        {
            InitializeComponent();
            SetControlesEstado(false);
            lblNombreMascota.Text = "";
        }
        public FrmConsultaAgregar(Mascota mascota)
        {
            InitializeComponent();
            mostrarMascota(mascota);
            setEstado(false);
        }

        IServiceEntidad<Consulta> logConsulta = new LogConsulta();
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        IServicePersonas<Veterinario> logVeterinario = new LogVeterinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = agregar(Mapeo());
                    if (message.Contains("Guardado"))
                    {
                        MessageBox.Show(message, "Agregar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else 
                    { 
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salir()
        {
            this.Close();
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(txtDiagnostico.Text)) throw new Exception("El campo Diagnóstico es obligatorio.");
            if (string.IsNullOrEmpty(txtTratamiento.Text)) throw new Exception("El campo Tratamiento es obligatorio.");
            return true;
        }
        private string agregar(Consulta consulta)
        {
            try
            {
                return logConsulta.Guardar(consulta);
            }
            catch (Exception e)
            {
                return e.Message;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
            
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
            cbxVeterinario.Enabled = estado;
            txtDiagnostico.Enabled = estado;
            txtTratamiento.Enabled = estado;
        }

        private void FrmConsultaAgregar_Load(object sender, EventArgs e)
        {
            cargarCmb();
        }

        private void cargarCmb()
        {
            cbxVeterinario.DataSource = logVeterinario.Consultar();
            cbxVeterinario.DisplayMember = "nombre";
            cbxVeterinario.ValueMember = "id";
        }

        private void setEstado(bool estado)
        {
            txtIdMascota.Enabled = estado;
            btnBuscarMascota.Enabled = estado;
        }
        private void mostrarMascota(Mascota mascota)
        {
            txtIdMascota.Text = mascota.id.ToString();
            lblNombreMascota.Text = mascota.nombre;
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
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
                lblNombreMascota.Text = mascota.nombre;
                SetControlesEstado(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Consulta Mapeo()
        {
            Mascota mascota = buscarMascota(int.Parse(txtIdMascota.Text));
            Veterinario veterinario = buscarVeterinario(int.Parse(cbxVeterinario.SelectedValue.ToString()));
            Consulta consulta = new Consulta();
            consulta.diagnostico = txtDiagnostico.Text;
            consulta.tratamiento = txtTratamiento.Text;
            consulta.mascota = mascota;
            consulta.veterinario = veterinario;
            return consulta;
        }
    }
}
