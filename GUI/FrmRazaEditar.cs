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
            this.raza = raza;
        }
        ICrud<Especie> logEspecie = new LogEspecie();
        IServiceRaza logRaza = new LogRaza();
        Raza raza;
        string idRaza;
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
                    if (message.Contains("correctamente"))
                    {
                        MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private Especie buscarEspecie(string id)
        {
            return logEspecie.BuscarPorId(id);
        }
        private Raza Mapeo()
        {
            Especie especie = buscarEspecie(cbxEspecie.SelectedValue.ToString());
            Raza raza = new Raza();
            raza.Codigo = idRaza;
            raza.Nombre = txtNombre.Text;
            raza.Especie = especie;
            return raza;
        }
    }
}

