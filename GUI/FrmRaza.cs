using System;
using System.Collections.Generic;
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
        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Ingrese el ID de la raza a buscar:", "Buscar Raza", "");
                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int id))
                    throw new Exception("El ID debe ser solo números");

                Raza raza = buscar(id);
                if (raza == null)
                {
                    MessageBox.Show("Raza no encontrada.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mostrarFrm(new FrmRazaEditar(raza));
                cargarDGV(razaService.Consultar());
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
                string input = Interaction.InputBox("Ingrese el codigo de la raza a eliminar:", "Eliminar Raza", "");
                if (string.IsNullOrWhiteSpace(input))
                    return;

                if (!int.TryParse(input, out int codigo))
                    throw new Exception("El código debe ser solo números");

                Raza raza = buscar(codigo);
                if (raza == null)
                {
                    MessageBox.Show("Raza no encontrada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmacion = dialogoPregunta("Eliminar la raza");
                if (confirmacion == DialogResult.Yes)
                {
                    borrar(codigo);
                    MessageBox.Show("Raza eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(razaService.Consultar());
                }
                else return;
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

        private void bttnFiltrarPorNombre_Click(object sender, EventArgs e)
        {
            if (txtFiltrarNombre.Text.Trim() == "")
            {
                cargarDGV(razaService.Consultar());
                return;
            }
            else 
            {
                razaService.BuscarPorNombre(txtFiltrarNombre.Text.Trim());
            }
        }

        private void bttnFiltrarEspecie_Click(object sender, EventArgs e)
        {
            if (txtFiltrarEspecie.Text.Trim() == "")
            {
                cargarDGV(razaService.Consultar());
                return;
            }
            else
            { 
                razaService.BuscarPorNombreEspecie(txtFiltrarEspecie.Text.Trim());
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
    }
}
