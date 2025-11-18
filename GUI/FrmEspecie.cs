using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;
using Microsoft.VisualBasic;


namespace ProyectoP3
{
    public partial class FrmEspecie : Form
    {
        EspecieService especieService;
        public FrmEspecie()
        {
            InitializeComponent();
            especieService = new EspecieService();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmEspecieAgregar());
            cargarDGV(especieService.Consultar());
        }
        private void FrmEspecie_Load(object sender, EventArgs e)
        {
            cargarDGV(especieService.Consultar());
        }
        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Digite el ID de la especie a buscar", "Editar Especie", "");
                if (string.IsNullOrWhiteSpace(input)) return;
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe ingresar un número válido.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var especie = especieService.buscar(id);
                if (especie == null)
                {
                    MessageBox.Show("Especie no encontrada", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mostrarFrm(new FrmEspecieEditar(especie));
                cargarDGV(especieService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Especie buscar(int codigo)
        {
            return especieService.buscar(codigo);
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Digite el ID de la especie a eliminar", "Eliminar Especie", "");
                if (string.IsNullOrWhiteSpace(input)) return;
                if (!int.TryParse(input, out int id))
                {
                    MessageBox.Show("Debe ingresar un número válido.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var especie = especieService.buscar(id);
                if (especie == null)
                {
                    MessageBox.Show("Especie no encontrada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dialogoPregunta("eliminar la especie") != DialogResult.Yes) return;

                eliminar(id);
                MessageBox.Show("Especie eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV(especieService.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool eliminar(int id)
        {
            try
            {
                return especieService.Borrar(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void cargarDGV(List<Especie> lista)
        {
            DGVEspecie.Rows.Clear();
            foreach (var especie in lista)
            {
                DGVEspecie.Rows.Add(especie.Codigo, especie.Nombre);
            }
        }
        private void bttnFiltrarNombre_Click(object sender, EventArgs e)
        {
            if (txtFiltrarNombre.Text.Trim() == "")
            {
                cargarDGV(especieService.Consultar());
                return;
            }
            else
            {
                cargarDGV(especieService.BuscarPorNombre(txtFiltrarNombre.Text.Trim()));
            }
        }

        private void DGVEspecie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(DGVEspecie.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVEspecie.Columns[e.ColumnIndex].Name == "Editar")
            {
                Especie especie = buscar(codigo);
                mostrarFrm(new FrmEspecieEditar(especie));
                cargarDGV(especieService.Consultar());
            }
            else if (DGVEspecie.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(especieService.Consultar());
                }
            }
        }
    }
}
