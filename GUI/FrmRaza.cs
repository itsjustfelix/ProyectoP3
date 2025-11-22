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
        RazaService razaService;
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
        private Raza buscar(int id)
        {
            return razaService.buscar(id);
        }
        private void mostrarFrm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private bool borrar(int id)
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
        private void cargarDGV(List<Raza> lista)
        {
            DGVRaza.Rows.Clear();
            foreach (var raza in lista)
            {
                DGVRaza.Rows.Add(raza.Codigo, raza.Nombre, raza.Especie.Nombre);
            }
        }

        private void DGVRaza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(DGVRaza.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVRaza.Columns[e.ColumnIndex].Name == "Editar")
            {
                Raza raza = buscar(codigo);
                mostrarFrm(new FrmRazaEditar(raza));
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

        private void txtFiltrarEspecie_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnFiltrarEspecie_Click_1(object sender, EventArgs e)
        {
            var texto = txtFiltrar.Text.Trim().ToLower();
            if (texto == "")
            {
                cargarDGV(razaService.Consultar());
                return;
            }
            else if(texto.All(char.IsLetter))
            {
                cargarDGV(razaService.BuscarPorNombre(texto));
                return;
            }
        }
    }
}
