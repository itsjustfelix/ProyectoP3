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
    public partial class FrmRazaAgregar : Form
    {
        public FrmRazaAgregar()
        {
            InitializeComponent();
        }
        LogEspecie logEspecie = new LogEspecie();
        LogRaza logRaza = new LogRaza();
        private void FrmRazaAgregar_Load(object sender, EventArgs e)
        {
            CargarCbx();
        }
        private void CargarCbx()
        {
            cbxEspecie.DataSource = logEspecie.Consultar();
            cbxEspecie.DisplayMember = "nombre";
            cbxEspecie.ValueMember = "id";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = agregar(Mapeo());
                    MessageBox.Show(message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salir();
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
        private string agregar(Raza raza)
        {
            try
            {
                return logRaza.Guardar(raza);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        private Especie buscarEspecie(int id)
        {
            return logEspecie.Consultar().FirstOrDefault(e => e.id == id);
            //TODO: esto no debe ir aqui, debo tener una funcion en la logica que me de el objeto.
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
        private Raza Mapeo()
        {
            Especie especie = buscarEspecie(int.Parse(cbxEspecie.SelectedValue.ToString()));
            Raza raza = new Raza();
            raza.nombre = txtNombre.Text;
            raza.especie = especie;
            return raza;
        }
    }
}

