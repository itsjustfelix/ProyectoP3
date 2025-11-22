using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace ProyectoP3
{
    public partial class FrmMascota : Form
    {
        MascotaService mascotaService;
        public FrmMascota()
        {
            InitializeComponent();
            mascotaService = new MascotaService();
        }
        private void cargarDGV(List<Mascota> lista)
        {
            DGVMascota.Rows.Clear();
            foreach (var item in lista)
            {
                DGVMascota.Rows.Add(
                    item.Codigo,
                    item.Nombre,
                    item.Especie.Nombre,
                    item.Raza.Nombre,
                    item.Propietario.Nombres
                    );
            }
        }

        private Mascota buscar(int id)
        {
            return mascotaService.buscar(id);
        }
        private bool borrar(int id)
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

        private void bttnFiltrarPorEspecie_Click(object sender, EventArgs e)
        {
            var texto = txtFiltrarEspecie.Text.Trim().ToLower();
            if (texto == "")
            {
                cargarDGV(mascotaService.Consultar());
                return;
            }
            else
            {
                cargarDGV(mascotaService.buscarPorRazaEspeciePropietario(texto));
            }
        }

        private void DGVMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = int.Parse(DGVMascota.CurrentRow.Cells["Codigo"].Value.ToString());
            if (DGVMascota.Columns[e.ColumnIndex].Name == "Editar")
            {
                Mascota mascota = buscar(codigo);
                mostrarFrm(new FrmMascotaEditar(mascota));
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

        private void txtFiltrarEspecie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
