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
            this.consulta = consulta;
            
            SetControlesEstado(false);
        }
        Consulta consulta;
        IServicePersonas<Veterinario> logVeterinario = new LogVeterinario();
        IServiceEntidad<Consulta> logConsulta = new LogConsulta();
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        string idConsulta;
        DateTime fechaConsulta;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    if (message.Contains("correctamente"))
                    {
                        MessageBox.Show(message, "Editar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(message, "Editar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void mostrarConsulta(Consulta consulta)
        {
            idConsulta = consulta.Codigo;
            fechaConsulta = consulta.Fecha;
            txtIdMascota.Text = consulta.Mascota.Codigo.ToString();
            lblNombreMascota.Text = consulta.Mascota.Nombre;
            cbxVeterinario.SelectedValue = consulta.Veterinario.Cedula;
            txtDiagnostico.Text = consulta.Diagnostico;
            txtTratamiento.Text = consulta.Tratamiento;
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
        private Mascota buscarMascota(string id)
        {
            return logMascota.BuscarPorId(id);
        }
        private Veterinario buscarVeterinario(string id)
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
            mostrarConsulta(consulta);
            cargarCmb();
        }
        private void cargarCmb()
        {
            cbxVeterinario.DataSource = logVeterinario.Consultar();
            cbxVeterinario.DisplayMember = "Nombres";
            cbxVeterinario.ValueMember = "Cedula";
        }

        private Consulta Mapeo()
        {
            Mascota mascota = buscarMascota(txtIdMascota.Text);
            Veterinario veterinario = buscarVeterinario(cbxVeterinario.SelectedValue.ToString());
            Consulta consulta = new Consulta();
            consulta.Codigo = idConsulta;
            consulta.Descripcion = txtDescripcion.Text;
            consulta.Diagnostico = txtDiagnostico.Text;
            consulta.Tratamiento = txtTratamiento.Text;
            consulta.Fecha = fechaConsulta;
            consulta.Mascota = mascota;
            consulta.Veterinario = veterinario;
            return consulta;
        }
    }
}
