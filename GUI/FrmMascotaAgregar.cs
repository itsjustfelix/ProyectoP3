using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascotaAgregar : Form
    {
        public FrmMascotaAgregar()
        {
            InitializeComponent();
        }
        IServicePersonas<Propietario> logPropietario = new LogPropietario();
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        IServiceEntidad<Especie> logEspecie = new LogEspecie();
        IServiceRaza logRaza = new LogRaza();
        private void bttnBuscarProp_Click(object sender, EventArgs e)
        {
            Propietario propietario = buscarPropietario(int.Parse(txtIdProprietario.Text));
            if (propietario == null)
            {
                MessageBox.Show("Propietario no encontrado", "Buscar Propietario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProprietario.Clear();
                SetControlesEstado(false);
                return;
            }
            lblNombreProp.Text = propietario.Nombre;
            SetControlesEstado(true);
        }
        private Propietario buscarPropietario(int id)
        {
            return logPropietario.BuscarPorId(id);
        }
        private void SetControlesEstado(bool estado)
        {
            txtNombre.Enabled = estado;
            cmbEspecie.Enabled = estado;
            cmbRaza.Enabled = estado;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = agregar(Mapeo());
                    if (message.Contains("Guardado"))
                    {
                        MessageBox.Show(message, "Agregar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentNullException("El nombre de la mascota es obligatorio.");
            return true;
        }
        private string agregar(Mascota mascota)
        {
            try
            {
                return logMascota.Guardar(mascota);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private Especie buscarEspecie(int id)
        {
            return logEspecie.BuscarPorId(id);
        }
        private Raza buscarRaza(int id)
        {
            return logRaza.BuscarPorId(id);
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
        private void FrmMascotaAgregar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecie();
            SetControlesEstado(false);
            lblNombreProp.Text = string.Empty;
        }
        private void cargarCmbEspecie()
        {
            cmbEspecie.DisplayMember = "Nombre";
            cmbEspecie.ValueMember = "Codigo";
            cmbEspecie.DataSource = logEspecie.Consultar();
        }
        private void cargarCmbRaza(int idEspecie)
        {
            cmbRaza.DataSource = null;
            cmbRaza.DataSource = logRaza.ConsultarPorEspecie(idEspecie);
            cmbRaza.DisplayMember = "Nombre";
            cmbRaza.ValueMember = "Codigo";
        }
        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCmbRaza(int.Parse(cmbEspecie.SelectedValue.ToString()));
        }

        private Mascota Mapeo()
        {
            Propietario propietario = buscarPropietario(int.Parse(txtIdProprietario.Text));
            Especie especie = buscarEspecie(int.Parse(cmbEspecie.SelectedValue.ToString()));
            Raza raza = buscarRaza(int.Parse(cmbRaza.SelectedValue.ToString()));
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Propietario = propietario;
            mascota.Especie = especie;
            mascota.Raza = raza;
            return mascota;
        }
    }
}
