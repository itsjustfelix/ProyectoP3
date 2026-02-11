using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmRazaEditar : Form
    {
        IEspecieService logEspecie;
        IRazaService logRaza;
        IDataEditService<RazaEdicionDTO> logRazaEdicion;
        string id;
        public FrmRazaEditar(string id)
        {
            InitializeComponent();
            this.id = id;
            logEspecie = new EspecieService();
            logRaza = new RazaService();
            logRazaEdicion = new RazaService();
        }
        private void mostrarRaza(RazaEdicionDTO raza)
        {
            txtNombre.Text = raza.Nombre;
            cbxEspecie.SelectedValue = raza.CodigoEspecie;
            id = raza.Codigo;
        }
        private void FrmRazaEditar_Load(object sender, EventArgs e)
        {
            cargarCmb();
            mostrarRaza(logRazaEdicion.ObtenerDatosEdicion(id));
        }
        private void cargarCmb()
        {
            cbxEspecie.DataSource = logEspecie.Consultar();
            cbxEspecie.DisplayMember = "nombre";
            cbxEspecie.ValueMember = "Codigo";
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            return true;
        }
        private bool editar(Raza raza)
        {
            try
            {
                return logRaza.Actualizar(raza);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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
        private void salir()
        {
            this.Close();
        }
        private Raza Mapeo()
        {
            Raza raza = new Raza();
            raza.Codigo = id;
            raza.Nombre = txtNombre.Text;
            raza.EspecieCodigo = cbxEspecie.SelectedValue.ToString();
            return raza;
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes) salir();
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
                        MessageBox.Show("Raza actualizada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de actualizar la raza correctamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

