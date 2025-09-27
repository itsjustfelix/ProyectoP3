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
    public partial class FrmRazaEditar : Form
    {
        public FrmRazaEditar(Raza raza)
        {
            InitializeComponent();
            mostrarRaza(raza);
        }
        LogEspecie logEspecie = new LogEspecie();
        LogRaza logRaza = new LogRaza();
        int idRaza;
        private void mostrarRaza(Raza raza)
        {
            txtNombre.Text = raza.nombre;
            cbxEspecie.SelectedValue = raza.especie.id;
            idRaza = raza.id;
        }
        private void FrmRazaEditar_Load(object sender, EventArgs e)
        {
            cargarCmb();
        }
        private void cargarCmb()
        {
            cbxEspecie.DataSource = logEspecie.Consultar();
            cbxEspecie.DisplayMember = "nombre";
            cbxEspecie.ValueMember = "id";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = editar(Mapeo());
                    MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private string editar(Raza raza)
        {
            try
            {
                return logRaza.Actualizar(raza);
            }
            catch (Exception e)
            {
                return e.Message;
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
            return logEspecie.Consultar().FirstOrDefault(e => e.id == id);
            //TODO: esto no debe de ir aqui, debo tener una funcion en la logica que me de el objeto.
        }
        private Raza Mapeo()
        {
            Especie especie = buscarEspecie(int.Parse(cbxEspecie.SelectedValue.ToString()));
            Raza raza = new Raza();
            raza.id = idRaza;
            raza.nombre = txtNombre.Text;
            raza.especie = especie;
            return raza;
        }
    }
}

