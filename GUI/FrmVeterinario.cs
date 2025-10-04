using System;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmVeterinario : Form
    {
        public FrmVeterinario()
        {
            InitializeComponent();
        }
        IServicePersonas<Veterinario> logVeterinario = new LogVeterinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmVeterinarioAgregar());
            cargarDGV();
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void cargarDGV()
        {
            DGVeterinario.Rows.Clear();
            foreach (var item in logVeterinario.Consultar())
            {
                DGVeterinario.Rows.Add(item.Cedula, item.Nombre, item.Sexo, item.Telefono);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el ID de la persona ha eliminar", "Eliminar Propietario", ""));
                Veterinario veterinario = buscar(id);
                if (veterinario == null)
                {
                    MessageBox.Show("Veterinario no encontrado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmVeterinarioEditar(veterinario));
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "";
                int id = int.Parse(Interaction.InputBox("Digite el ID de la persona ha eliminar", "Eliminar Propietario", ""));
                Veterinario veterinario = buscar(id);
                if (veterinario == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes) message = eliminar(id);
                else if (respuesta == DialogResult.No) message = "Eliminacion cancelada";
                else if (respuesta == DialogResult.None) message = "Eliminacion cancelada";
                MessageBox.Show(message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Veterinario buscar(int id)
        {
            try
            {
                return logVeterinario.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        private string eliminar(int codigo)
        {
            try
            {
                return logVeterinario.Borrar(codigo);
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
    }
}
