using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascotaAgregar : Form
    {
        IPropietarioService logPropietario;
        IMascotaService logMascota;
        IEspecieService logEspecie;
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
        private Propietario buscarPropietario(string id)
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
        private void cargarCmbRaza(string idEspecie)
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
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.PropietarioCedula = txtIdProprietario.Text;
            mascota.EspecieCodigo = cmbEspecie.SelectedValue.ToString();
            mascota.RazaCodigo = cmbRaza.SelectedValue.ToString();
            return mascota;
        }

        private void cmbEspecie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarCmbRaza(cmbEspecie.SelectedValue.ToString());
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtIdProprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Propietario propietario = buscarPropietario(txtIdProprietario.Text);
                    if (propietario == null)
                    {
                        MessageBox.Show("Propietario no encontrado", "Buscar Propietario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdProprietario.Clear();
                        SetControlesEstado(false);
                        return;
                    }
                    lblNombreProp.Text = propietario.NombreCompleto;
                    SetControlesEstado(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese un ID de propietario válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtIdProprietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
