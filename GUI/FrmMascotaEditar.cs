using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascotaEditar : Form
    {
        public FrmMascotaEditar(Mascota mascota)
        {
            InitializeComponent();
            this.mascota = mascota;
            setEstadoControles(false);
        }
        IServicePersonas<Propietario> logPropietario = new LogPropietario();
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        IServiceEntidad<Especie> logEspecie = new LogEspecie();
        IServiceRaza logRaza = new LogRaza();
        private Mascota mascota;
        string id;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    MessageBox.Show(message, "Editar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void mostrarMascota(Mascota mascota)
        {
            txtIdProprietario.Text = mascota.Propietario.Cedula.ToString();
            lblNombreProp.Text = mascota.Propietario.Nombres;
            txtNombre.Text = mascota.Nombre;
            cmbEspecie.SelectedValue = mascota.Especie.Codigo;
            cmbRaza.SelectedValue = mascota.Raza.Codigo;
            id = mascota.Codigo;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentNullException("El nombre de la mascota es obligatorio.");
            return true;
        }
        private string editar(Mascota mascota)
        {
            try
            {
                return logMascota.Actualizar(mascota);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private Especie buscarEspecie(string id)
        {
            return logEspecie.BuscarPorId(id);
        }
        private Raza buscarRaza(string id)
        {
            return logRaza.BuscarPorId(id);
        }
        private Propietario buscarPropietario(string id)
        {
            return logPropietario.BuscarPorId(id);
        }
        private void setEstadoControles(bool estado)
        {
            txtIdProprietario.Enabled = estado;
        }
        private void salir()
        {
            this.Close();
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
        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCmbRaza(cmbEspecie.SelectedValue.ToString());
        }
        private void cargarCmbEspecie()
        {
            cmbEspecie.DataSource = logEspecie.Consultar();
            cmbEspecie.DisplayMember = "Nombre";
            cmbEspecie.ValueMember = "Codigo";
            
        }
        private void cargarCmbRaza(string idEspecie)
        {
            cmbRaza.DataSource = null;
            cmbRaza.DataSource = logRaza.ConsultarPorEspecie(idEspecie);
            cmbRaza.DisplayMember = "Nombre";
            cmbRaza.ValueMember = "Codigo";
        }
        private void FrmMascotaEditar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecie();
            mostrarMascota(mascota);
        }
        private Mascota Mapeo()
        {
            Propietario propietario = buscarPropietario(txtIdProprietario.Text);
            Especie especie = buscarEspecie(cmbEspecie.SelectedValue.ToString());
            Raza raza = buscarRaza(cmbRaza.SelectedValue.ToString());
            Mascota mascota = new Mascota();
            mascota.Codigo = id;
            mascota.Nombre = txtNombre.Text;
            mascota.Especie = especie;
            mascota.Raza = raza;
            mascota.Propietario = propietario;
            return mascota;
        }
    }
}
