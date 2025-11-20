using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;


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
        private Especie buscar(int codigo)
        {
            return especieService.buscar(codigo);
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
