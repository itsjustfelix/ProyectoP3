using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascota : Form
    {
        IMascotaService mascotaService;
        public FrmMascota()
        {
            InitializeComponent();
            mascotaService = new MascotaService();
        }
        private void cargarDGV(List<MascotaDTO> lista)
        {
            DGVMascota.Rows.Clear();
            foreach (var item in lista)
            {
                DGVMascota.Rows.Add(
                    item.Codigo,
                    item.Nombre,
                    item.NombreEspecie,
                    item.NombreRaza,
                    item.NombrePropietario
                    );
            }
        }

        private MascotaDTO buscar(string id)
        {
            return mascotaService.buscar(id);
        }
        private bool borrar(string id)
        {
            try
            {
                return mascotaService.Borrar(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
        private void FrmMascota_Load(object sender, EventArgs e)
        {
            cargarDGV(mascotaService.Consultar());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mostrarFrm(new FrmMascotaAgregar());
            cargarDGV(mascotaService.Consultar());
        }

        private void DGVMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = DGVMascota.CurrentRow.Cells["Codigo"].Value.ToString();
            if (DGVMascota.Columns[e.ColumnIndex].Name == "Editar")
            {
                mostrarFrm(new FrmMascotaEditar(codigo));
                cargarDGV(mascotaService.Consultar());
            }
            else if (DGVMascota.Columns[e.ColumnIndex].Name == "elimina")
            {
                var respuesta = dialogoPregunta("eliminar");
                if (respuesta == DialogResult.Yes)
                {
                    borrar(codigo);
                    MessageBox.Show("Veterinario eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDGV(mascotaService.Consultar());
                }
            }
        }

        private void txtFiltrarEspecie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var texto = txtFiltrarEspecie.Text.Trim().ToLower();
                if (texto == "") cargarDGV(mascotaService.Consultar());
                else cargarDGV(mascotaService.buscarPorRazaEspeciePropietario(texto));
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
