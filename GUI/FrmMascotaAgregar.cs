using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascotaAgregar : Form
    {
        ICrud<Propietario> logPropietario;
        ICrud<Mascota> logMascota;
        ICrud<Especie> logEspecie;
        IServiceRaza logRaza;
        public FrmMascotaAgregar()
        {
            InitializeComponent();
            logPropietario = new LogPropietario();
            logMascota = new LogMascota();
            logEspecie = new LogEspecie();
            logRaza = new LogRaza();
        }
        private void bttnBuscarProp_Click(object sender, EventArgs e)
        {
            Propietario propietario = buscarPropietario(txtIdProprietario.Text);
            if (propietario == null)
            {
                MessageBox.Show("Propietario no encontrado", "Buscar Propietario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProprietario.Clear();
                SetControlesEstado(false);
                return;
            }
            lblNombreProp.Text = propietario.Nombres;
            SetControlesEstado(true);
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
        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCmbRaza(cmbEspecie.SelectedValue.ToString());
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
        private void SetControlesEstado(bool estado)
        {
            txtNombre.Enabled = estado;
            cmbEspecie.Enabled = estado;
            cmbRaza.Enabled = estado;
        }
        private void cargarCmbEspecie()
        {
            cmbEspecie.DataSource = null;
            cmbEspecie.DataSource = logEspecie.Consultar();
            cmbEspecie.DisplayMember = "Nombre";
            cmbEspecie.ValueMember = "Codigo";
        }
        private void cargarCmbRaza(string idEspecie)
        {
            cmbRaza.DataSource = null;
            cmbRaza.DataSource = logRaza.BuscarPorCualidad(idEspecie);
            cmbRaza.DisplayMember = "Nombre";
            cmbRaza.ValueMember = "Codigo";
        }
        private void salir()
        {
            this.Close();
        }
        private Mascota Mapeo()
        {
            Propietario propietario = buscarPropietario(txtIdProprietario.Text);
            Especie especie = buscarEspecie(cmbEspecie.SelectedValue.ToString());
            Raza raza = buscarRaza(cmbRaza.SelectedValue.ToString());
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Propietario = propietario;
            mascota.Especie = especie;
            mascota.Raza = raza;
            return mascota;
        }
    }
}
