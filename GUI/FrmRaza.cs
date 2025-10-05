using System;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;
namespace ProyectoP3
{
    public partial class FrmRaza : Form
    {
        public FrmRaza()
        {
            InitializeComponent();
        }
        IServiceRaza logRaza = new LogRaza();
        private void FrmRaza_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmRazaAgregar());
            cargarDGV();
        }
        private void cargarDGV()
        {
            DGVRaza.Rows.Clear();
            foreach (var raza in logRaza.Consultar())
            {
                DGVRaza.Rows.Add(raza.Codigo, raza.Nombre, raza.Especie.Nombre);
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
        private void tbnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Ingrese el ID de la raza a buscar:", "Buscar Raza", ""));
                Raza raza = buscarRaza(id);
                if (raza == null)
                {
                    MessageBox.Show("Raza no encontrada.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmRazaEditar(raza));
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "";
                int codigo = int.Parse(Interaction.InputBox("Ingrese el codigo de la raza a eliminar:", "Eliminar Raza", ""));
                Raza raza = buscarRaza(codigo);
                if (raza == null)
                {
                    MessageBox.Show("Raza no encontrada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var confirmacion = dialogoPregunta("Eliminar la raza");
                if (confirmacion == DialogResult.Yes)
                {
                    message = borrar(codigo);
                    MessageBox.Show(message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string borrar(int id)
        {
            try
            {
                return logRaza.Borrar(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        private Raza buscarRaza(int id)
        {
            return logRaza.BuscarPorId(id);
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
