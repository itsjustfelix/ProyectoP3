using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascotaEditar : Form
    {
        ICrud<Propietario> logPropietario;
        ICrud<Mascota> logMascota;
        ICrud<Especie> logEspecie;
        IServiceRaza logRaza;
        private Mascota mascota;
        int codigo;
        public FrmMascotaEditar(Mascota mascota)
        {
            InitializeComponent();
            this.mascota = mascota;
            setEstadoControles(false);
            logPropietario = new PropietarioService();
            logMascota = new MascotaService();
            logEspecie = new EspecieService();
            logRaza = new RazaService();
        }
        
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
            codigo = mascota.Codigo;
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
        private Especie buscarEspecie(int id)
        {
            return logEspecie.BuscarPorId(id);
        }
        private Raza buscarRaza(int id)
        {
            return logRaza.BuscarPorId(id);
        }
        private Propietario buscarPropietario(int id)
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
            cargarCmbRaza(int.Parse(cmbEspecie.SelectedValue.ToString()));
        }
        private void cargarCmbEspecie()
        {
            cmbEspecie.DataSource = logEspecie.Consultar();
            cmbEspecie.DisplayMember = "Nombre";
            cmbEspecie.ValueMember = "Codigo";
            
        }
        private void cargarCmbRaza(int idEspecie)
        {
            cmbRaza.DataSource = null;
            cmbRaza.DataSource = logRaza.BuscarPorCualidad(idEspecie);
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
            Propietario propietario = buscarPropietario(int.Parse(txtIdProprietario.Text));
            Especie especie = buscarEspecie(int.Parse(cmbEspecie.SelectedValue.ToString()));
            Raza raza = buscarRaza(int.Parse(cmbRaza.SelectedValue.ToString()));
            Mascota mascota = new Mascota();
            mascota.Codigo = codigo;
            mascota.Nombre = txtNombre.Text;
            mascota.Especie = especie;
            mascota.Raza = raza;
            mascota.Propietario = propietario;
            return mascota;
        }
    }
}
