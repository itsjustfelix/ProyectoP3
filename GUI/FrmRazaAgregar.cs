using System;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmRazaAgregar : Form
    {
        public FrmRazaAgregar()
        {
            InitializeComponent();
            logEspecie = new EspecieService();
            logRaza = new RazaService();
        }
        ICrud<Especie> logEspecie;
        IRazaService logRaza;
        private void FrmRazaAgregar_Load(object sender, EventArgs e)
        {
            CargarCbx();
        }
        private void CargarCbx()
        {
            cbxEspecie.DataSource = logEspecie.Consultar();
            cbxEspecie.DisplayMember = "Nombre";
            cbxEspecie.ValueMember = "Codigo";
        }
       
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            return true;
        }
        private bool agregar(Raza raza)
        {
            try
            {
                return logRaza.Guardar(raza);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private Especie buscarEspecie(int id)
        {
            return logEspecie.BuscarPorId(id);
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
            Especie especie = buscarEspecie(int.Parse(cbxEspecie.SelectedValue.ToString()));
            Raza raza = new Raza();
            raza.Nombre = txtNombre.Text;
            raza.Especie = especie;
            return raza;
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
                        MessageBox.Show("Raza guardada correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al momento de guardar la raza.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

