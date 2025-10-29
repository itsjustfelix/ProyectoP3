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
        IServiceEntidad<Especie> logEspecie = new LogEspecie();
        IServiceRaza logRaza = new LogRaza();
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var message = agregar(Mapeo());
                    if (message.Contains("Guardado"))
                    {
                        MessageBox.Show(message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private Especie buscarEspecie(string id)
        {
            return logEspecie.BuscarPorId(id);
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
            Especie especie = buscarEspecie(cbxEspecie.SelectedValue.ToString());
            Raza raza = new Raza();
            raza.Nombre = txtNombre.Text;
            raza.Especie = especie;
            return raza;
        }
    }
}

