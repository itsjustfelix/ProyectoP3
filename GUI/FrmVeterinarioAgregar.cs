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
    public partial class FrmVeterinarioAgregar : Form
    {
        public FrmVeterinarioAgregar()
        {
            InitializeComponent();
        }
        IServicePersonas<Veterinario> logVeterinario = new LogVeterinario();
        IServiceEntidad<Especializacion> logEspecializacion = new logEspecializacion();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    var mensaje = agregar(Mapeo());
                    if (mensaje.Contains("Guardado"))
                    {
                        MessageBox.Show(mensaje, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        salir();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private string agregar(Veterinario veterinario)
        {
            try
            {
                return logVeterinario.Guardar(veterinario);
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
        private DialogResult dialogoPregunta(string accion)
        {
            return MessageBox.Show(
             $"¿Está seguro de que desea {accion}?",
             $"Confirmar {accion}",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var respuesta = dialogoPregunta("cancelar");
            if (respuesta == DialogResult.Yes)
            {
                salir();
            }
        }
        private Veterinario Mapeo()
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(txtId.Text);
            veterinario.Nombres = txtNombre.Text;
            veterinario.Sexo = RBFemenino.Checked ? "Femenino" : "Masculino";
            veterinario.TelefonoPrimario = txtNumTlf.Text;
            veterinario.Especializacion = buscarEspecializacion(int.Parse(cmbEspecilizacion.SelectedValue.ToString()));
            return veterinario;
        }
        private Especializacion buscarEspecializacion(int codigo)
        {
           return logEspecializacion.BuscarPorId(codigo);
        }
        private bool validar()
        {
            if (string.IsNullOrEmpty(txtId.Text)) throw new ArgumentNullException("El campo Cédula es obligatorio.");
            if (string.IsNullOrEmpty(txtNombre.Text)) throw new ArgumentNullException("El campo Nombre es obligatorio.");
            if (string.IsNullOrEmpty(txtNumTlf.Text)) throw new ArgumentNullException("El campo Teléfono es obligatorio.");
            if (!RBFemenino.Checked && !RBMasculino.Checked) throw new ArgumentNullException("El campo Sexo es obligatorio.");
            return true;
        }
        private void cargarCmbEspecializacion()
        {
            cmbEspecilizacion.DataSource = logEspecializacion.Consultar();
            cmbEspecilizacion.DisplayMember = "Nombre";
            cmbEspecilizacion.ValueMember = "Codigo";
        }
        private void FrmVeterinarioAgregar_Load(object sender, EventArgs e)
        {
            cargarCmbEspecializacion();
        }
    }
}
