using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmConsultaEditar : Form
    {
        Consulta consulta;
        IVeterinarioService logVeterinario = new VeterinarioService();
        ICrud<Consulta> logConsulta = new ConsultaService();
        ICrud<Mascota> logMascota = new MascotaService();
        int idConsulta;
        int cedulaVeterinario;
        string fechaConsulta;
        public FrmConsultaEditar(Consulta consulta)
        {
            InitializeComponent();
            this.consulta = consulta;
            SetControlesEstado(false);
        }


        private void FrmConsultaEditar_Load(object sender, EventArgs e)
        {
            mostrarConsulta(consulta);
        }

        
        private Consulta Mapeo()
        {
            Mascota mascota = buscarMascota(int.Parse(txtIdMascota.Text));
            Veterinario veterinario = buscarVeterinario(cedulaVeterinario);
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
            txtEspecializacion.Text = consulta.Veterinario.Especializacion.Nombre;
            txtVeterinario.Text = consulta.Veterinario.Nombres;
            cedulaVeterinario = consulta.Veterinario.Cedula;
            txtDescripcion.Text = consulta.Descripcion;
            txtDiagnostico.Text = consulta.Diagnostico;
            txtTratamiento.Text = consulta.Tratamiento;
        }
        private void SetControlesEstado(bool estado)
        {
            txtIdMascota.Enabled = estado;
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text)) throw new Exception("El campo Descripción es obligatorio.");
            if (string.IsNullOrEmpty(txtDiagnostico.Text)) throw new Exception("El campo Diagnóstico es obligatorio.");
            if (string.IsNullOrEmpty(txtTratamiento.Text)) throw new Exception("El campo Tratamiento es obligatorio.");
            return true;
        }
        private bool editar(Consulta consulta)
        {
            try
            {
                return logConsulta.Actualizar(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar la consulta: {ex.Message}", ex);
            }
        }
        private Mascota buscarMascota(int id)
        {
            return logMascota.buscar(id);
        }
        private Veterinario buscarVeterinario(int id)
        {
            return logVeterinario.buscar(id);
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    if (message)
                    {
                        MessageBox.Show("Consulta actualizada correctamente.", "Editar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de actualizar la consulta", "Editar Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
