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
    public partial class FrmMascotaEditar : Form
    {
        public FrmMascotaEditar(Mascota mascota)
        {
            InitializeComponent();
            mostrarMascota(mascota);
            setEstadoControles(false);
        }
        IServicePersonas<Propietario> logPropietario = new LogPropietario();
        IServiceEntidad<Mascota> logMascota = new LogMascota();
        IServiceEntidad<Especie> logEspecie = new LogEspecie();
        IServiceRaza logRaza = new LogRaza();
        int id;
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
            txtIdProprietario.Text = mascota.propietario.Cedula.ToString();
            lblNombreProp.Text = mascota.propietario.Nombre;
            txtNombre.Text = mascota.nombre;
            cmbEspecie.SelectedValue = mascota.especie.id;
            cmbRaza.SelectedValue = mascota.raza.id;
            id = mascota.id;
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
                Propietario propietario = buscarPropietario(int.Parse(txtIdProprietario.Text));
                Especie especie = buscarEspecie(int.Parse(cmbEspecie.SelectedValue.ToString()));
                Raza raza = buscarRaza(int.Parse(cmbRaza.SelectedValue.ToString()));
                return logMascota.Actualizar(new Mascota(id, txtNombre.Text, especie, raza, propietario));
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
            cmbEspecie.DisplayMember = "nombre";
            cmbEspecie.ValueMember = "id";
            cmbEspecie.DataSource = logEspecie.Consultar();
        }
        private void cargarCmbRaza(int idEspecie)
        {
            cmbRaza.DataSource = null;
            cmbRaza.DataSource = logRaza.ConsultarPorEspecie(idEspecie);
            cmbRaza.DisplayMember = "nombre";
            cmbRaza.ValueMember = "id";
        }
        private void FrmMascotaEditar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecie();
        }
        private Mascota Mapeo()
        {
            Propietario propietario = buscarPropietario(int.Parse(txtIdProprietario.Text));
            Especie especie = buscarEspecie(int.Parse(cmbEspecie.SelectedValue.ToString()));
            Raza raza = buscarRaza(int.Parse(cmbRaza.SelectedValue.ToString()));
            Mascota mascota = new Mascota();
            mascota.id = id;
            mascota.nombre = txtNombre.Text;
            mascota.especie = especie;
            mascota.raza = raza;
            mascota.propietario = propietario;
            return mascota;
        }
    }
}
