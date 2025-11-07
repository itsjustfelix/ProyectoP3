using System;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;

namespace ProyectoP3
{
    public partial class FrmPropietario : Form
    {
        public FrmPropietario()
        {
            InitializeComponent();
            propietarioService = new PropietarioService();
        }

        ICrud<Propietario> propietarioService;

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            mostrarFrm(new FrmPropietarioAgregar());
            cargarDGV();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite la cedula del propietario ha buscar", "Buscar Propietario", ""));
                Propietario propietario = buscar(id);
                if (propietario == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mostrarFrm(new FrmEditarPropietatio(propietario));
                cargarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("La cedula debe ser solamente numeros", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(Interaction.InputBox("Digite el ID de la persona ha eliminar", "Eliminar Propietario", ""));
                Propietario propietario = buscar(id);
                if (propietario == null)
                {
                    MessageBox.Show("Propietario no encontrado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.No || respuesta == DialogResult.None)
                {
                    MessageBox.Show("Eliminación cancelada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var message = eliminar(id); 
                MessageBox.Show(message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private string eliminar(int id)
        {
            try
            {
                return propietarioService.Borrar(id);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        private Propietario buscar(int id)
        {
            try
            {
                return propietarioService.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
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
        private void cargarDGV()
        {
            DGVPropietario.Rows.Clear();
            foreach (var item in propietarioService.Consultar())
            {
                DGVPropietario.Rows.Add(
                    item.Cedula,
                    item.Nombres,
                    item.ApellidoPaterno,
                    item.ApellidoMaterno,
                    item.Sexo,
                    item.Telefono,
                    item.Email
                );
            }
        }

    }
}
