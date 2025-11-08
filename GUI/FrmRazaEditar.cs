using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmRazaEditar : Form
    {
        ICrud<Especie> logEspecie;
        IServiceRaza logRaza;
        Raza raza;
        int idRaza;
        public FrmRazaEditar(Raza raza)
        {
            InitializeComponent();
            this.raza = raza;
            logEspecie = new EspecieService();
            logRaza = new RazaService();
        }
        private void mostrarRaza(Raza raza)
        {
            txtNombre.Text = raza.Nombre;
            cbxEspecie.SelectedValue = raza.Especie.Codigo;
            idRaza = raza.Codigo;
        }
        private void FrmRazaEditar_Load(object sender, EventArgs e)
        {
            cargarCmb();
            mostrarRaza(raza);
        }
        private void cargarCmb()
        {
            cbxEspecie.DataSource = logEspecie.Consultar();
            cbxEspecie.DisplayMember = "nombre";
            cbxEspecie.ValueMember = "Codigo";
        }
        private void btnEditar_Click(object sender, EventArgs e)
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
        private void salir()
        {
            this.Close();
        }
        private Especie buscarEspecie(int id)
        {
            return logEspecie.BuscarPorId(id);
        }
        private Raza Mapeo()
        {
            Especie especie = buscarEspecie(int.Parse(cbxEspecie.SelectedValue.ToString()));
            Raza raza = new Raza();
            raza.Codigo = idRaza;
            raza.Nombre = txtNombre.Text;
            raza.Especie = especie;
            return raza;
        }
    }
}

