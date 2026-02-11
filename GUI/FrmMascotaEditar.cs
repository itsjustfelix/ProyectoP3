using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascotaEditar : Form
    {
        IMascotaService logMascota;
        IEspecieService logEspecie;
        IRazaService logRaza;
        string codigo;
        public FrmMascotaEditar(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            setEstadoControles(false);
            logMascota = new MascotaService();
            logEspecie = new EspecieService();
            logRaza = new RazaService();
        }
        
        
        private void mostrarMascota(MascotaEdicionDTO mascota)
        {
            txtIdProprietario.Text = mascota.CedulaPropietario;
            lblNombreProp.Text = mascota.NombrePropietario;
            txtNombre.Text = mascota.Nombre;
            cmbEspecie.SelectedValue = mascota.CodigoEspecie;
            cmbRaza.SelectedValue = mascota.CodigoRaza;
            codigo = mascota.Codigo;
        }
        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentNullException("El nombre de la mascota es obligatorio.");
            return true;
        }
        private bool editar(Mascota mascota)
        {
            try
            {
                return logMascota.Actualizar(mascota);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void setEstadoControles(bool estado)
        {
            txtIdProprietario.Enabled = estado;
        }
        private void salir()
        {
            this.Close();
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
      
        private void cargarCmbEspecie()
        {
            cmbEspecie.DataSource = logEspecie.Consultar();
            cmbEspecie.DisplayMember = "Nombre";
            cmbEspecie.ValueMember = "Codigo";
            
        }
        private void cargarCmbRaza(string id)
        {
            cmbRaza.DataSource = logRaza.BuscarPorEspecie(id);
            cmbRaza.DisplayMember = "Nombre";
            cmbRaza.ValueMember = "Codigo";
        }
        private void FrmMascotaEditar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecie();
            mostrarMascota(logMascota.ObtenerDatosEdicion(codigo));
        }
        private Mascota Mapeo()
        {
            Mascota mascota = new Mascota();
            mascota.Codigo = codigo;
            mascota.Nombre = txtNombre.Text;
            mascota.EspecieCodigo = cmbEspecie.SelectedValue.ToString();
            mascota.RazaCodigo = cmbRaza.SelectedValue.ToString();
            mascota.PropietarioCedula = txtIdProprietario.Text;
            return mascota;
        }

        private void cmbEspecie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.Text = cmbEspecie.SelectedValue.ToString();
            cargarCmbRaza(cmbEspecie.SelectedValue.ToString());
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
                        MessageBox.Show("Mascota actualizada correctamente.", "Editar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de actualizar la mascota.", "Editar Mascota", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
