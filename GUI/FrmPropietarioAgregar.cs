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
    public partial class FrmPropietarioAgregar : Form
    {
        public FrmPropietarioAgregar()
        {
            InitializeComponent();
        }
        LogPropietario logPropietario = new LogPropietario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var mesaje = agregar(Mappeo());
            MessageBox.Show(mesaje, "Agregar Propietario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            salir();
        }

        private string agregar(Propietario propietario)
        {
            try
            {
                return logPropietario.Guardar(propietario);
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        private void salir()
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if(respuesta == DialogResult.Yes)
            {
                salir();
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

        private Propietario Mappeo()
        {
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(txtId.Text);
            propietario.Nombre = txtNombre.Text;
            propietario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            propietario.Telefono = txtNumTlf.Text;
            return propietario;
        }
    }
}
