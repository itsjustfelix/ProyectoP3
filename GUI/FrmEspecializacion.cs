using System;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;
namespace ProyectoP3
{
    public partial class FrmEspecializacion : Form
    {
        ICrud<Especializacion> logEspecializacion = new EspecializacionService();
        public FrmEspecializacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmEspecializacionAgregar());
            cargarDGV();
        }

        private void cargarDGV()
        {
            DGVEspecializacion.Rows.Clear();
            foreach (var item in logEspecializacion.Consultar())
            {
                DGVEspecializacion.Rows.Add(item.Codigo, item.Nombre);
            }
        }

        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
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

        private void FrmEspecializacion_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el codigo de la especializacion ha eliminar", "Eliminar especilizacion", ""));
                Especializacion especializacion = buscar(id);
                if (especializacion == null)
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

        private string eliminar(int id)
        {
            try
            {
                return logEspecializacion.Borrar(id);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private Especializacion buscar(int id)
        {
            try
            {
                return logEspecializacion.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Interaction.InputBox("Digite el codigo de la especializacion ha buscar", "Buscar especializacion", ""));
                Especializacion especializacion = buscar(id);
                if (especializacion == null)
                {
                    MessageBox.Show("Especializacion no encontrada", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mostrarFrm(new FrmEspecializacionEditar(especializacion));
                cargarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("el codigo debe ser solamente numeros", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
