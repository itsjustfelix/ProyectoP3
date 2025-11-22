using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace ProyectoP3
{
    public partial class FrmEspecializacion : Form
    {
        EspecializacionService especializacionService;
        public FrmEspecializacion()
        {
            InitializeComponent();
            especializacionService = new EspecializacionService();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmEspecializacionAgregar());
            cargarDGV(especializacionService.Consultar());
        }


        private void cargarDGV(List<Especializacion> lista)
        {
            DGVEspecializacion.Rows.Clear();
            foreach (var item in lista)
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
            cargarDGV(especializacionService.Consultar());
        }



        private bool eliminar(int id)
        {
            try
            {
                return especializacionService.Borrar(id);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al agregar la consulta: {e.Message}", e);
            }
        }

        private Especializacion buscar(int id)
        {
            try
            {
                return especializacionService.buscar(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        private void bttnFiltrarPorNombre_Click(object sender, EventArgs e)
        {
            var texto = txtFiltrarPorNombre.Text.Trim().ToLower();
            if (texto == "")
            {
                cargarDGV(especializacionService.Consultar());
                return;
            }
            else
            {
                cargarDGV(especializacionService.BuscarPorNombre(texto));
                return;
            }
        }

        private void DGVEspecializacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(DGVEspecializacion.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVEspecializacion.Columns[e.ColumnIndex].Name == "Editar")
            {
                Especializacion especializacion = buscar(codigo);
                mostrarFrm(new FrmEspecializacionEditar(especializacion));
                cargarDGV(especializacionService.Consultar());
            }
            else if (DGVEspecializacion.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(especializacionService.Consultar());
                }
            }
        }
    }
}
