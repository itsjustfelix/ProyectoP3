using System;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmVeterinario : Form
    {
        IServiceVeterinario VeterinarioService;
        public FrmVeterinario()
        {
            InitializeComponent();
            VeterinarioService = new VeterinarioService();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private Veterinario buscar(int codigo)
        {
            try
            {
                return VeterinarioService.BuscarPorId(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        private bool eliminar(int codigo)
        {
            try
            {
                return VeterinarioService.Borrar(codigo);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
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
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void cargarDGV()
        {
            DGVeterinario.Rows.Clear();
            foreach (var item in VeterinarioService.Consultar())
            {
                DGVeterinario.Rows.Add(
                    item.Cedula,
                    item.Nombres,
                    item.ApellidoMaterno,
                    item.ApellidoMaterno,
                    item.Sexo,
                    item.Telefono,
                    item.Especializacion.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmVeterinarioAgregar());
            cargarDGV();
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el ID de la persona ha eliminar", "Eliminar Propietario", ""));
                Veterinario veterinario = buscar(id);
                if (veterinario == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(id);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
