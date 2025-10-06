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
        IServicePersonas<Propietario> logPropietario = new LogPropietario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    string mensaje = agregar(Mappeo());
                    if (mensaje.Contains("Guardado"))
                    {
                        MessageBox.Show(mensaje, "Agregar Propietario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

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
            if (respuesta == DialogResult.Yes)
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
            propietario.Nombres = txtNombre.Text;
            propietario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            propietario.TelefonoPrimario = txtNumTlf.Text;
            return propietario;
        }

        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) throw new ArgumentNullException("La cédula es obligatoria.");
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new ArgumentNullException("El nombre del propietario es obligatorio.");
            if (string.IsNullOrWhiteSpace(txtNumTlf.Text)) throw new ArgumentNullException("El número de teléfono es obligatorio.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentException("Debe seleccionar un género.");
            return true;
        }
    }
}
