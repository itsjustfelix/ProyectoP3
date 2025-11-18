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
        IRazaService logRaza;
        public FrmMascotaAgregar()
        {
            InitializeComponent();
            logPropietario = new PropietarioService();
            logMascota = new MascotaService();
            logEspecie = new EspecieService();
            logRaza = new RazaService();
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
       
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentNullException("El nombre de la mascota es obligatorio.");
            return true;
        }
        private bool agregar(Mascota mascota)
        {
            try
            {
                return logMascota.Guardar(mascota);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar la mascota: {ex.Message}", ex);
            }
        }
        private Especie buscarEspecie(int id)
        {
            return logEspecie.buscar(id);
        }
        private Raza buscarRaza(int id)
        {
            return logRaza.buscar(id);
        }
        private Propietario buscarPropietario(int id)
        {
            return logPropietario.buscar(id);
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
            cmbEspecie.DisplayMember = "Nombre";
            cmbEspecie.ValueMember = "Codigo";
            cmbEspecie.DataSource = logEspecie.Consultar();
        }
        private void cargarCmbRaza(int idEspecie)
        {
            cmbRaza.DataSource = null;
            cmbRaza.DataSource = logRaza.BuscarPorEspecie(idEspecie);
            cmbRaza.DisplayMember = "Nombre";
            cmbRaza.ValueMember = "Codigo";
        }
        private void salir()
        {
            this.Close();
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

        private void cmbEspecie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarCmbRaza(int.Parse(cmbEspecie.SelectedValue.ToString()));
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = agregar(Mapeo());
                    if (message)
                    {
                        MessageBox.Show("Mascota guardada correctamente.", "Agregar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de guardar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Propietario propietario = buscarPropietario(int.Parse(txtIdProprietario.Text));
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
    }
}
