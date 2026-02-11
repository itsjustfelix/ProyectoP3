using System;
using System.Collections.Generic;
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
            razaService = new RazaService();
        }
        IRazaService razaService;
        private void FrmRaza_Load(object sender, EventArgs e)
        {
            cargarDGV(razaService.Consultar());
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmRazaAgregar());
            cargarDGV(razaService.Consultar());
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
        private RazaDTO buscar(string id)
        {
            return razaService.buscar(id);
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private bool borrar(string id)
        {
            try
            {
                return razaService.Borrar(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        private void cargarDGV(List<RazaDTO> lista)
        {
            DGVRaza.Rows.Clear();
            foreach (var raza in lista)
            {
                DGVRaza.Rows.Add(
                    raza.Codigo,
                    raza.Nombre,
                    raza.NombreEspecie
                    );
            }
        }
        private void DGVRaza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = DGVRaza.CurrentRow.Cells["Codigo"].Value.ToString();
            if (DGVRaza.Columns[e.ColumnIndex].Name == "Editar")
            {
                mostrarFrm(new FrmRazaEditar(codigo));
                cargarDGV(razaService.Consultar());
            }
            else if (DGVRaza.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    borrar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(razaService.Consultar());
                }
            }
        }
        private void txtFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var texto = txtFiltrar.Text.Trim().ToLower();
                if (texto == "") cargarDGV(razaService.Consultar());
                else if (texto.All(char.IsLetter)) cargarDGV(razaService.BuscarPorNombreEspecie(texto));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
