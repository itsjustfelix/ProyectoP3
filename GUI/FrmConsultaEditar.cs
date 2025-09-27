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
    public partial class FrmConsultaEditar : Form
    {
        public FrmConsultaEditar(Consulta consulta)
        {
            InitializeComponent();
            mostrarConsulta(consulta);
            SetControlesEstado(false);
        }
        LogVeterinario logVeterinario = new LogVeterinario();
        LogConsulta logConsulta = new LogConsulta();
        LogMascota logMascota = new LogMascota();
        int idConsulta;
        DateTime fechaConsulta;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    MessageBox.Show(message, "Editar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salir();
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
        private void mostrarConsulta(Consulta consulta)
        {
            idConsulta = consulta.id;
            fechaConsulta = consulta.fecha;
            txtIdMascota.Text = consulta.mascota.id.ToString();
            lblNombreMascota.Text = consulta.mascota.nombre;
            cbxVeterinario.SelectedValue = consulta.veterinario.Cedula;
            txtDiagnostico.Text = consulta.diagnostico;
            txtTratamiento.Text = consulta.tratamiento;
        }
        private void SetControlesEstado(bool estado)
        {
            txtIdMascota.Enabled = estado;
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtDiagnostico.Text)) throw new Exception("El campo Diagnóstico es obligatorio.");
            if (string.IsNullOrEmpty(txtTratamiento.Text)) throw new Exception("El campo Tratamiento es obligatorio.");
            return true;
        }
        private string editar(Consulta consulta)
        {
            try
            {
                return logConsulta.Actualizar(consulta);
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
        private void FrmConsultaEditar_Load(object sender, EventArgs e)
        {
            cargarCmb();
        }
        private void cargarCmb()
        {
            cbxVeterinario.DataSource = logVeterinario.Consultar();
            cbxVeterinario.DisplayMember = "nombre";
            cbxVeterinario.ValueMember = "id";
        }

        private Consulta Mapeo()
        {
            Mascota mascota = buscarMascota(int.Parse(txtIdMascota.Text));
            Veterinario veterinario = buscarVeterinario(int.Parse(cbxVeterinario.SelectedValue.ToString()));
            Consulta consulta = new Consulta();
            consulta.id = idConsulta;
            consulta.diagnostico = txtDiagnostico.Text;
            consulta.tratamiento = txtTratamiento.Text;
            consulta.mascota = mascota;
            consulta.veterinario = veterinario;
            return consulta;
        }
    }
}
