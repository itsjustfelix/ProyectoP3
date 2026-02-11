using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmVeterinario : Form
    {
        VeterinarioService VeterinarioService;
        public FrmVeterinario()
        {
            InitializeComponent();
            VeterinarioService = new VeterinarioService();
        }
        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            cargarDGV(VeterinarioService.Consultar());
        }
        private VeterinarioDTO buscar(string codigo)
        {
            try
            {
                return VeterinarioService.buscar(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        private bool eliminar(string codigo)
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
        private void cargarDGV(List<VeterinarioDTO> lista)
        {
            DGVeterinario.Rows.Clear();
            foreach (var item in lista)
            {
                DGVeterinario.Rows.Add(
                    item.Cedula,
                    item.NombreCompleto,
                    item.Sexo,
                    item.Telefono,
                    item.NombreEspecializacion);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmVeterinarioAgregar());
            cargarDGV(VeterinarioService.Consultar());
        }

        private void DGVeterinario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cedula = DGVeterinario.CurrentRow.Cells["Cedula"].Value.ToString();
            if (DGVeterinario.Columns[e.ColumnIndex].Name == "Editar")
            {
                mostrarFrm(new FrmVeterinarioEditar(cedula));
                cargarDGV(VeterinarioService.Consultar());
            }
            else if (DGVeterinario.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    eliminar(cedula);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(VeterinarioService.Consultar());
                }
            }
        }

        private void txtFiltrarEspecializacion_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var texto = txtFiltrarEspecializacion.Text.Trim().ToLower();
                if (texto == "")cargarDGV(VeterinarioService.Consultar());
                else cargarDGV(VeterinarioService.bsucarPorNombreEspecializacion(texto));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
