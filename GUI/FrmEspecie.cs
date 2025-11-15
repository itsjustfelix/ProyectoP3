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
        EspecieService logEspecie;
        public FrmEspecie()
        {
            InitializeComponent();
            logEspecie = new EspecieService();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmEspecieAgregar());
            cargarDGV(logEspecie.Consultar());
        }
        private void FrmEspecie_Load(object sender, EventArgs e)
        {
            cargarDGV(logEspecie.Consultar());
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

                var especie = logEspecie.BuscarPorId(id);
                if (especie == null)
                {
                    MessageBox.Show("Especie no encontrada", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                mostrarFrm(new FrmEspecieEditar(especie));
                cargarDGV(logEspecie.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                var especie = logEspecie.BuscarPorId(id);
                if (especie == null)
                {
                    MessageBox.Show("Especie no encontrada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dialogoPregunta("eliminar la especie") != DialogResult.Yes) return;

                borrar(id);
                MessageBox.Show("Especie eliminada correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDGV(logEspecie.Consultar());
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
        private bool borrar(int id)
        {
            try
            {
                return logEspecie.Borrar(id);
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
                cargarDGV(logEspecie.Consultar());
                return;
            }
            else
            {
                cargarDGV(logEspecie.BuscarPorNombre(txtFiltrarNombre.Text.Trim()));
            }
        }
    }
}
